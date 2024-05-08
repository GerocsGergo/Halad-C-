
namespace VillamosTest
{
    partial class Form_MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_ScoreBoard = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.label_GameNameMainMenu = new System.Windows.Forms.Label();
            this.button_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(244, 398);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(330, 40);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.Location = new System.Drawing.Point(244, 288);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(330, 40);
            this.button_Settings.TabIndex = 1;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_ScoreBoard
            // 
            this.button_ScoreBoard.Location = new System.Drawing.Point(244, 242);
            this.button_ScoreBoard.Name = "button_ScoreBoard";
            this.button_ScoreBoard.Size = new System.Drawing.Size(330, 40);
            this.button_ScoreBoard.TabIndex = 2;
            this.button_ScoreBoard.Text = "Scoreboard";
            this.button_ScoreBoard.UseVisualStyleBackColor = true;
            this.button_ScoreBoard.Click += new System.EventHandler(this.button_ScoreBoard_Click);
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(244, 196);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(330, 40);
            this.button_Play.TabIndex = 3;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // label_GameNameMainMenu
            // 
            this.label_GameNameMainMenu.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_GameNameMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_GameNameMainMenu.Location = new System.Drawing.Point(229, -1);
            this.label_GameNameMainMenu.Name = "label_GameNameMainMenu";
            this.label_GameNameMainMenu.Size = new System.Drawing.Size(368, 128);
            this.label_GameNameMainMenu.TabIndex = 4;
            this.label_GameNameMainMenu.Text = "Combine";
            this.label_GameNameMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(244, 334);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(330, 40);
            this.button_Help.TabIndex = 5;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VillamosTest.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.label_GameNameMainMenu);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.button_ScoreBoard);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.button_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_MainMenu";
            this.Text = "Combine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_ScoreBoard;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Label label_GameNameMainMenu;
        private System.Windows.Forms.Button button_Help;
    }
}

