
namespace VillamosTest
{
    partial class Form_GameOver
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Retry = new System.Windows.Forms.Button();
            this.label_GameOver = new System.Windows.Forms.Label();
            this.label_ScoreLABEL = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_ProfileLabel = new System.Windows.Forms.Label();
            this.textBox_ProfileValue = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(408, 112);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(162, 29);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit to Windows";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(240, 112);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(162, 29);
            this.button_Menu.TabIndex = 1;
            this.button_Menu.Text = "Back to MainMenu";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // button_Retry
            // 
            this.button_Retry.Location = new System.Drawing.Point(12, 112);
            this.button_Retry.Name = "button_Retry";
            this.button_Retry.Size = new System.Drawing.Size(109, 29);
            this.button_Retry.TabIndex = 2;
            this.button_Retry.Text = "Retry";
            this.button_Retry.UseVisualStyleBackColor = true;
            this.button_Retry.Click += new System.EventHandler(this.button_Retry_Click);
            // 
            // label_GameOver
            // 
            this.label_GameOver.Location = new System.Drawing.Point(12, 7);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(99, 22);
            this.label_GameOver.TabIndex = 3;
            this.label_GameOver.Text = "GAME OVER!";
            // 
            // label_ScoreLABEL
            // 
            this.label_ScoreLABEL.Location = new System.Drawing.Point(133, 55);
            this.label_ScoreLABEL.Name = "label_ScoreLABEL";
            this.label_ScoreLABEL.Size = new System.Drawing.Size(99, 20);
            this.label_ScoreLABEL.TabIndex = 4;
            this.label_ScoreLABEL.Text = "You scored::";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(240, 55);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(32, 20);
            this.label_Score.TabIndex = 5;
            this.label_Score.Text = "asd";
            // 
            // label_ProfileLabel
            // 
            this.label_ProfileLabel.AutoSize = true;
            this.label_ProfileLabel.Location = new System.Drawing.Point(133, 9);
            this.label_ProfileLabel.Name = "label_ProfileLabel";
            this.label_ProfileLabel.Size = new System.Drawing.Size(99, 20);
            this.label_ProfileLabel.TabIndex = 6;
            this.label_ProfileLabel.Text = "Profile Name:";
            // 
            // textBox_ProfileValue
            // 
            this.textBox_ProfileValue.Location = new System.Drawing.Point(238, 12);
            this.textBox_ProfileValue.Name = "textBox_ProfileValue";
            this.textBox_ProfileValue.Size = new System.Drawing.Size(164, 27);
            this.textBox_ProfileValue.TabIndex = 7;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(408, 12);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(162, 27);
            this.button_Apply.TabIndex = 8;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // Form_GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 153);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_ProfileValue);
            this.Controls.Add(this.label_ProfileLabel);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label_ScoreLABEL);
            this.Controls.Add(this.label_GameOver);
            this.Controls.Add(this.button_Retry);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.button_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.Name = "Form_GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_Retry;
        private System.Windows.Forms.Label label_GameOver;
        private System.Windows.Forms.Label label_ScoreLABEL;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label_ProfileLabel;
        private System.Windows.Forms.TextBox textBox_ProfileValue;
        private System.Windows.Forms.Button button_Apply;
    }
}