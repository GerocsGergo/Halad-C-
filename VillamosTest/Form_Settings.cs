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


    public partial class Form_Settings : Form
    {
        Functions functions = new Functions();
        public Dictionary<string, string> settingDic = new Dictionary<string, string>();
        public List<string> toFile = new List<string>();
        public string difficulty;

        public Form_Settings()
        {
            InitializeComponent();
            settingDic.Clear();
            toFile.Clear();

            var lines = File.ReadAllLines("Settings.txt").Select(x => new Functions.Settings(x)).ToArray();
            difficulty = lines.Where(x => x.name == "difficulty").Select(x => x.value).First().ToString();
            label_DiffValue.Text = difficulty;
            trackBar_Difficulty.Value = functions.SetTrackBarDifficulty(difficulty);

        }




        private void button_MainMenu_Click(object sender, EventArgs e)
        {
            Form_MainMenu form_MainMenu = new Form_MainMenu();
            form_MainMenu.Show();
            this.Hide();

        }

        private void trackBar_Difficulty_Scroll(object sender, EventArgs e)
        {

            label_DiffValue.Text = functions.TrackBarDifficulty(trackBar_Difficulty.Value);

        }


        private void button_Apply_Click(object sender, EventArgs e)
        {
            settingDic.Clear();
            toFile.Clear();

            TextBox[] textBoxes = functions.BadBoxes(textBox_Up, textBox_Down, textBox_Left, textBox_Right); ;
            bool bindingIsBad = true; //true ha van rossz, false ha nincs

            if (textBoxes.Length == 0)
            {
                bindingIsBad = false;
            }

            foreach (var textBox in textBoxes)
            {
                textBox.BackColor = Color.Red;
                textBox.Text = "";
            }

            if (bindingIsBad == false)
            {

                var lines = File.ReadAllLines("Settings.txt").Select(x => new Functions.Settings(x)).ToArray();
                difficulty = lines.Where(x => x.name == "difficulty").Select(x => x.value).First().ToString();
                foreach (var line in lines)
                {
                    settingDic.Add(line.name, line.value);
                }
                if (difficulty != label_DiffValue.Text)
                {
                    foreach (var setting in settingDic)
                    {
                        try
                        {
                            settingDic["difficulty"] = label_DiffValue.Text;
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
                settingDic["up"] = textBox_Up.Text.ToLower();
                settingDic["down"] = textBox_Down.Text.ToLower();
                settingDic["left"] = textBox_Left.Text.ToLower();
                settingDic["right"] = textBox_Right.Text.ToLower();

                textBox_Up.BackColor = Color.White;
                textBox_Down.BackColor = Color.White;
                textBox_Right.BackColor = Color.White;
                textBox_Left.BackColor = Color.White;

                foreach (var setting in settingDic)
                {
                    toFile.Add(setting.Key + " " + setting.Value);
                }
                File.WriteAllLines("Settings.txt", toFile);
                MessageBox.Show("Settings applied");
            }
            else
            {
                MessageBox.Show("The keybindings must be letters or arrow keys!");
            }


        }

        private void button_Default_Click(object sender, EventArgs e)
        {
            textBox_Up.Text = "w";
            textBox_Down.Text = "s";
            textBox_Right.Text = "d";
            textBox_Left.Text = "a";
        }

        private void button_Arrows_Click(object sender, EventArgs e)
        {
            textBox_Up.Text = Keys.Up.ToString();
            textBox_Down.Text = Keys.Down.ToString();
            textBox_Right.Text = Keys.Right.ToString();
            textBox_Left.Text = Keys.Left.ToString();
        }
    }
}
