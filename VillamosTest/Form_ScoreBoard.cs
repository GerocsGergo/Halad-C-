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
    public partial class Form_ScoreBoard : Form
    {

        Functions functions = new Functions();
        public Form_ScoreBoard()
        {
            InitializeComponent();
            dataGridView_Scores.Columns.Add("ID", "ID");
            dataGridView_Scores.Columns.Add("Name", "Name");
            dataGridView_Scores.Columns.Add("HighScore", "HighScore");
            functions.TableProfil("Profiles.txt", dataGridView_Scores);
        }

        private void button_MainMenu_Click(object sender, EventArgs e)
        {
            Form_MainMenu form_MainMenu = new Form_MainMenu();
            form_MainMenu.Show();
            this.Hide();
        }
    }
}
