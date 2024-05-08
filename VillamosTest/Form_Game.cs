using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillamosTest
{
    public partial class Form_Game : Form
    {
        VillamosFunctions villamosFunctions = new VillamosFunctions();
        bool rotateRight = false;
        bool rotateLeft = false;
        bool rotateUp = false;
        bool rotateDown = false;
        int happened = 0;
        int score = 0;
        int time = 0;
        int minutes = 0;
        int seconds = 0;
        int wheatCount = 0;
        int cornCount = 0;
        int farmerCount = 0;
        int fuel = 100;
        int speed;
        string PressedKey = "w";
        string lastMovementDirection = "w";
        string difficulty;
        PictureBox pictureBox_Score;
        PictureBox pictureBox_Farmer;
        PictureBox pictureBox_Fuel;
        PictureBox pictureBox_Boulder;
        public Dictionary<string, string> settingDic = new Dictionary<string, string>();


        public Form_Game()
        {

            InitializeComponent();
            timer_Timer.Start();
            villamosFunctions.SetXY(villamosFunctions.OneVillamos, pictureBox_Head);

            pictureBox_Score = villamosFunctions.ScoreGeneratorFirst(panel_Map);
            panel_Map.Controls.Add(pictureBox_Score);

            pictureBox_Farmer = villamosFunctions.FarmerGenerator(panel_Map, pictureBox_Score, pictureBox_Head);
            panel_Map.Controls.Add(pictureBox_Farmer);

            pictureBox_Fuel = villamosFunctions.FuelGenerator(panel_Map, pictureBox_Score, pictureBox_Head, pictureBox_Farmer);
            panel_Map.Controls.Add(pictureBox_Fuel);

            pictureBox_Boulder = villamosFunctions.BoulderGenerator(panel_Map, pictureBox_Score, pictureBox_Head, pictureBox_Farmer, pictureBox_Fuel);
            panel_Map.Controls.Add(pictureBox_Boulder);

            var lines = File.ReadAllLines("Settings.txt").Select(x => new Functions.Settings(x)).ToArray();
            foreach (var line in lines)
            {
                settingDic.Add(line.name, line.value);
            }
            PressedKey = settingDic["up"];
            lastMovementDirection = settingDic["up"];

            difficulty = lines.Where(x => x.name == "difficulty").Select(x => x.value).First().ToString();
            label_Difficulty.Text = difficulty;
            speed = villamosFunctions.SetSpeed(difficulty);

        }

        private void Form_Game_KeyDown(object sender, KeyEventArgs e)
        {   //mozgás- ,forgáshoz változo beallitas
            try
            {
                PressedKey = e.KeyCode.ToString().ToLower();
                if (PressedKey == settingDic["right"] && lastMovementDirection != settingDic["left"])
                {
                    lastMovementDirection = PressedKey;
                    rotateRight = true;
                    pictureBox_Head.Invalidate();
                }
                else if (PressedKey == settingDic["left"] && lastMovementDirection != settingDic["right"])
                {
                    lastMovementDirection = PressedKey;
                    rotateLeft = true;
                    pictureBox_Head.Invalidate();
                }
                else if (PressedKey == settingDic["up"] && lastMovementDirection != settingDic["down"])
                {
                    lastMovementDirection = PressedKey;
                    rotateUp = true;
                    pictureBox_Head.Invalidate();
                }
                else if (PressedKey == settingDic["down"] && lastMovementDirection != settingDic["up"])
                {
                    lastMovementDirection = PressedKey;
                    rotateDown = true;
                    pictureBox_Head.Invalidate();
                }

                //if (PressedKey == "d" && lastMovementDirection != "a")
                //{
                //    lastMovementDirection = PressedKey;
                //    rotateRight = true;
                //    pictureBox_Head.Invalidate();
                //}
                //else if (PressedKey == "a" && lastMovementDirection != "d")
                //{
                //    lastMovementDirection = PressedKey;
                //    rotateLeft = true;
                //    pictureBox_Head.Invalidate();
                //}
                //else if (PressedKey == "w" && lastMovementDirection != "s")
                //{
                //    lastMovementDirection = PressedKey;
                //    rotateUp = true;
                //    pictureBox_Head.Invalidate();
                //}
                //else if (PressedKey == "s" && lastMovementDirection != "w")
                //{
                //    lastMovementDirection = PressedKey;
                //    rotateDown = true;
                //    pictureBox_Head.Invalidate();
                //}
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        private void pictureBox_Head_Paint(object sender, PaintEventArgs e)
        {   //forgatás
            villamosFunctions.VillamosRotate(rotateRight, rotateLeft, rotateUp, rotateDown, pictureBox_Head, e);
            rotateDown = false;
            rotateUp = false;
            rotateRight = false;
            rotateLeft = false;
        }

        private void timer_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                happened = villamosFunctions.VillamosKeys(pictureBox_Boulder, pictureBox_Fuel, pictureBox_Farmer, pictureBox_Head, pictureBox_TopWall, pictureBox_DownWall, pictureBox_LeftWall, pictureBox_RightWall, pictureBox_Score);

            }
            catch (Exception ex2)
            {

                Console.WriteLine(ex2.Message);
            }
            //történések 1 ha gameover, 2 ha score, 3 ha farmer, 4 ha fuel
            //gameoverek
            if (time == 2400)
            {
                happened = 1;
            }
            else if (fuel == 0)
            {
                happened = 1;
            }
            //minden más
            try
            {
                if (happened == 1)
                {
                    timer_Timer.Stop();
                    Form_GameOver form_GameOver = new Form_GameOver(score);
                    form_GameOver.Show();
                    this.Hide();
                }
                else if (happened == 2)
                {
                    if (pictureBox_Score.Tag.ToString() == "Corn")
                    {
                        label_Corn.Text = cornCount++.ToString();
                        score += 50;
                    }
                    else
                    {
                        label_Wheat.Text = wheatCount++.ToString();
                        score += 10;
                    }

                }
                else if (happened == 3)
                {
                    label_Farmer.Text = farmerCount++.ToString();
                    score -= 30;

                }
                else if (happened == 4)
                {
                    fuel = 100;
                }

                if (happened == 3 || happened == 2 || happened == 4)
                {
                    pictureBox_Score.Hide();
                    pictureBox_Score = villamosFunctions.ScoreGenerator(panel_Map, pictureBox_Head);
                    panel_Map.Controls.Add(pictureBox_Score);

                    pictureBox_Farmer.Hide();
                    pictureBox_Farmer = villamosFunctions.FarmerGenerator(panel_Map, pictureBox_Score, pictureBox_Head);
                    panel_Map.Controls.Add(pictureBox_Farmer);

                    pictureBox_Fuel.Hide();
                    pictureBox_Fuel = villamosFunctions.FuelGenerator(panel_Map, pictureBox_Score, pictureBox_Head, pictureBox_Farmer);
                    panel_Map.Controls.Add(pictureBox_Fuel);

                    pictureBox_Boulder.Hide();
                    pictureBox_Boulder = villamosFunctions.BoulderGenerator(panel_Map, pictureBox_Score, pictureBox_Head, pictureBox_Farmer, pictureBox_Fuel);
                    panel_Map.Controls.Add(pictureBox_Boulder);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            //mozgás és pontszám

            villamosFunctions.VillamosMovement(pictureBox_Head, lastMovementDirection, speed, settingDic);
            if (time % 10 == 0)
            {
                score++;
                fuel--;
                if (difficulty == "Impossible")
                {
                    fuel -= 10;
                }
            }

            time++;
            seconds = (time - minutes * 600) / 10;
            minutes = (time / 10) / 60;

            label_Timer.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
            label_Score.Text = score.ToString();
            progressBar_Fuel.Value = fuel;

        }
    }
}








