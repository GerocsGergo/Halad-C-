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
    public partial class Form_GameOver : Form
    {
        public List<string> toFile = new List<string>();
        public List<List<string>> profiles = new List<List<string>>();
        public List<string> oneProfile = new List<string>();

        int nextId;
        string score;
        string name;
        public bool applied = false;

        public Form_GameOver(int score)
        {
            InitializeComponent();
            label_Score.Text = score.ToString();


        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            if (applied)
            {
                Functions.CloseAllForms();
                Application.Exit();
            }
            else
            {
                textBox_ProfileValue.BackColor = Color.Red;
                MessageBox.Show("Name needed");
            }

        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            if (applied)
            {
                Form_MainMenu form_MainMenu = new Form_MainMenu();
                form_MainMenu.Show();
                this.Hide();
            }
            else
            {
                textBox_ProfileValue.BackColor = Color.Red;
                MessageBox.Show("Name needed");
            }

        }

        private void button_Retry_Click(object sender, EventArgs e)
        {
            if (applied)
            {
                Form_Game form_Game = new Form_Game();
                form_Game.Show();
                this.Hide();
            }
            else
            {
                textBox_ProfileValue.BackColor = Color.Red;
                MessageBox.Show("Name needed");
            }

        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            
            if (textBox_ProfileValue.Text.Length >= 10)
            {
                textBox_ProfileValue.BackColor = Color.Blue;
                MessageBox.Show("Name needs to be less than 10 character");
                applied = false;
            }
            else
            {
                applied = true;

                try
                {
                    var lines = File.ReadAllLines("Profiles.txt").Select(x => new Functions.Profile(x)).ToArray();

                    nextId = lines.Select(x => x.ID).Max() + 1;
                    score = label_Score.Text;
                    name = textBox_ProfileValue.Text;

                    toFile.Add(nextId + " " + name + " " + score);
                    File.AppendAllLines("Profiles.txt", toFile);
                    MessageBox.Show("Profile added");
                }
                catch (Exception)
                {
                    toFile.Add("0 default 0");
                    File.AppendAllLines("Profiles.txt", toFile);
                    toFile.Clear();

                    var lines = File.ReadAllLines("Profiles.txt").Select(x => new Functions.Profile(x)).ToArray();

                    nextId = lines.Select(x => x.ID).Max() + 1;
                    score = label_Score.Text;
                    name = textBox_ProfileValue.Text;

                    toFile.Add(nextId + " " + name + " " + score);
                    File.AppendAllLines("Profiles.txt", toFile);
                    MessageBox.Show("Profile added");
                }
            }



        }
    }
}
