using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillamosTest
{
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();
            label_GameNameMainMenu.BackColor = System.Drawing.Color.Transparent;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Functions.CloseAllForms();
            Application.Exit();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            Form_Settings form_Settings = new Form_Settings();
            form_Settings.Show();
            this.Hide();
            
            
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            Form_Game form_Game = new Form_Game();
            form_Game.Show();
            this.Hide();
        }

        private void button_ScoreBoard_Click(object sender, EventArgs e)
        {
            Form_ScoreBoard form_ScoreBoard = new Form_ScoreBoard();
            form_ScoreBoard.Show();
            this.Hide();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Form_Help form_Help = new Form_Help();
            form_Help.Show();
            this.Hide();
        }
    }
}
