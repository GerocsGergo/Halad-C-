
namespace VillamosTest
{
    partial class Form_ScoreBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_MainMenu = new System.Windows.Forms.Button();
            this.dataGridView_Scores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Scores)).BeginInit();
            this.SuspendLayout();
            // 
            // button_MainMenu
            // 
            this.button_MainMenu.Location = new System.Drawing.Point(12, 312);
            this.button_MainMenu.Name = "button_MainMenu";
            this.button_MainMenu.Size = new System.Drawing.Size(558, 29);
            this.button_MainMenu.TabIndex = 0;
            this.button_MainMenu.Text = "Back to MainMenu";
            this.button_MainMenu.UseVisualStyleBackColor = true;
            this.button_MainMenu.Click += new System.EventHandler(this.button_MainMenu_Click);
            // 
            // dataGridView_Scores
            // 
            this.dataGridView_Scores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Scores.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Scores.Name = "dataGridView_Scores";
            this.dataGridView_Scores.RowHeadersWidth = 51;
            this.dataGridView_Scores.RowTemplate.Height = 29;
            this.dataGridView_Scores.Size = new System.Drawing.Size(558, 294);
            this.dataGridView_Scores.TabIndex = 1;
            // 
            // Form_ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.dataGridView_Scores);
            this.Controls.Add(this.button_MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_ScoreBoard";
            this.Text = "ScoreBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Scores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_MainMenu;
        private System.Windows.Forms.DataGridView dataGridView_Scores;
    }
}