
namespace VillamosTest
{
    partial class Form_Settings
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
            this.trackBar_Difficulty = new System.Windows.Forms.TrackBar();
            this.label_Difficulty = new System.Windows.Forms.Label();
            this.label_DiffValue = new System.Windows.Forms.Label();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label_KeyBindingsLabel = new System.Windows.Forms.Label();
            this.label_UpLabel = new System.Windows.Forms.Label();
            this.label_DownLabel = new System.Windows.Forms.Label();
            this.label_RightLabel = new System.Windows.Forms.Label();
            this.label_LeftLabel = new System.Windows.Forms.Label();
            this.textBox_Up = new System.Windows.Forms.TextBox();
            this.textBox_Down = new System.Windows.Forms.TextBox();
            this.textBox_Right = new System.Windows.Forms.TextBox();
            this.textBox_Left = new System.Windows.Forms.TextBox();
            this.button_Default = new System.Windows.Forms.Button();
            this.button_Arrows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Difficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // button_MainMenu
            // 
            this.button_MainMenu.Location = new System.Drawing.Point(12, 398);
            this.button_MainMenu.Name = "button_MainMenu";
            this.button_MainMenu.Size = new System.Drawing.Size(429, 40);
            this.button_MainMenu.TabIndex = 1;
            this.button_MainMenu.Text = "Back to MainMenu";
            this.button_MainMenu.UseVisualStyleBackColor = true;
            this.button_MainMenu.Click += new System.EventHandler(this.button_MainMenu_Click);
            // 
            // trackBar_Difficulty
            // 
            this.trackBar_Difficulty.Location = new System.Drawing.Point(458, 68);
            this.trackBar_Difficulty.Maximum = 2;
            this.trackBar_Difficulty.Name = "trackBar_Difficulty";
            this.trackBar_Difficulty.Size = new System.Drawing.Size(330, 56);
            this.trackBar_Difficulty.TabIndex = 2;
            this.trackBar_Difficulty.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Difficulty.Scroll += new System.EventHandler(this.trackBar_Difficulty_Scroll);
            // 
            // label_Difficulty
            // 
            this.label_Difficulty.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Difficulty.Location = new System.Drawing.Point(458, 9);
            this.label_Difficulty.Name = "label_Difficulty";
            this.label_Difficulty.Size = new System.Drawing.Size(165, 56);
            this.label_Difficulty.TabIndex = 3;
            this.label_Difficulty.Text = "Difficulty:";
            this.label_Difficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DiffValue
            // 
            this.label_DiffValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DiffValue.Location = new System.Drawing.Point(623, 9);
            this.label_DiffValue.Name = "label_DiffValue";
            this.label_DiffValue.Size = new System.Drawing.Size(165, 56);
            this.label_DiffValue.TabIndex = 4;
            this.label_DiffValue.Text = "Easy";
            this.label_DiffValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(458, 398);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(330, 40);
            this.button_Apply.TabIndex = 14;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label_KeyBindingsLabel
            // 
            this.label_KeyBindingsLabel.AutoSize = true;
            this.label_KeyBindingsLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_KeyBindingsLabel.Location = new System.Drawing.Point(12, 20);
            this.label_KeyBindingsLabel.Name = "label_KeyBindingsLabel";
            this.label_KeyBindingsLabel.Size = new System.Drawing.Size(151, 35);
            this.label_KeyBindingsLabel.TabIndex = 15;
            this.label_KeyBindingsLabel.Text = "Keybindings";
            // 
            // label_UpLabel
            // 
            this.label_UpLabel.AutoSize = true;
            this.label_UpLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_UpLabel.Location = new System.Drawing.Point(12, 70);
            this.label_UpLabel.Name = "label_UpLabel";
            this.label_UpLabel.Size = new System.Drawing.Size(52, 35);
            this.label_UpLabel.TabIndex = 16;
            this.label_UpLabel.Text = "Up:";
            // 
            // label_DownLabel
            // 
            this.label_DownLabel.AutoSize = true;
            this.label_DownLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DownLabel.Location = new System.Drawing.Point(12, 120);
            this.label_DownLabel.Name = "label_DownLabel";
            this.label_DownLabel.Size = new System.Drawing.Size(85, 35);
            this.label_DownLabel.TabIndex = 17;
            this.label_DownLabel.Text = "Down:";
            // 
            // label_RightLabel
            // 
            this.label_RightLabel.AutoSize = true;
            this.label_RightLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_RightLabel.Location = new System.Drawing.Point(12, 170);
            this.label_RightLabel.Name = "label_RightLabel";
            this.label_RightLabel.Size = new System.Drawing.Size(78, 35);
            this.label_RightLabel.TabIndex = 18;
            this.label_RightLabel.Text = "Right:";
            // 
            // label_LeftLabel
            // 
            this.label_LeftLabel.AutoSize = true;
            this.label_LeftLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LeftLabel.Location = new System.Drawing.Point(12, 220);
            this.label_LeftLabel.Name = "label_LeftLabel";
            this.label_LeftLabel.Size = new System.Drawing.Size(61, 35);
            this.label_LeftLabel.TabIndex = 19;
            this.label_LeftLabel.Text = "Left:";
            // 
            // textBox_Up
            // 
            this.textBox_Up.Location = new System.Drawing.Point(157, 78);
            this.textBox_Up.Name = "textBox_Up";
            this.textBox_Up.Size = new System.Drawing.Size(125, 27);
            this.textBox_Up.TabIndex = 20;
            // 
            // textBox_Down
            // 
            this.textBox_Down.Location = new System.Drawing.Point(157, 128);
            this.textBox_Down.Name = "textBox_Down";
            this.textBox_Down.Size = new System.Drawing.Size(125, 27);
            this.textBox_Down.TabIndex = 21;
            // 
            // textBox_Right
            // 
            this.textBox_Right.Location = new System.Drawing.Point(157, 178);
            this.textBox_Right.Name = "textBox_Right";
            this.textBox_Right.Size = new System.Drawing.Size(125, 27);
            this.textBox_Right.TabIndex = 22;
            // 
            // textBox_Left
            // 
            this.textBox_Left.Location = new System.Drawing.Point(157, 228);
            this.textBox_Left.Name = "textBox_Left";
            this.textBox_Left.Size = new System.Drawing.Size(125, 27);
            this.textBox_Left.TabIndex = 23;
            // 
            // button_Default
            // 
            this.button_Default.Location = new System.Drawing.Point(12, 268);
            this.button_Default.Name = "button_Default";
            this.button_Default.Size = new System.Drawing.Size(137, 29);
            this.button_Default.TabIndex = 24;
            this.button_Default.Text = "Default";
            this.button_Default.UseVisualStyleBackColor = true;
            this.button_Default.Click += new System.EventHandler(this.button_Default_Click);
            // 
            // button_Arrows
            // 
            this.button_Arrows.Location = new System.Drawing.Point(157, 268);
            this.button_Arrows.Name = "button_Arrows";
            this.button_Arrows.Size = new System.Drawing.Size(125, 29);
            this.button_Arrows.TabIndex = 25;
            this.button_Arrows.Text = "Use Arrow keys";
            this.button_Arrows.UseVisualStyleBackColor = true;
            this.button_Arrows.Click += new System.EventHandler(this.button_Arrows_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Arrows);
            this.Controls.Add(this.button_Default);
            this.Controls.Add(this.textBox_Left);
            this.Controls.Add(this.textBox_Right);
            this.Controls.Add(this.textBox_Down);
            this.Controls.Add(this.textBox_Up);
            this.Controls.Add(this.label_LeftLabel);
            this.Controls.Add(this.label_RightLabel);
            this.Controls.Add(this.label_DownLabel);
            this.Controls.Add(this.label_UpLabel);
            this.Controls.Add(this.label_KeyBindingsLabel);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.label_DiffValue);
            this.Controls.Add(this.label_Difficulty);
            this.Controls.Add(this.trackBar_Difficulty);
            this.Controls.Add(this.button_MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Difficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_MainMenu;
        private System.Windows.Forms.TrackBar trackBar_Difficulty;
        private System.Windows.Forms.Label label_Difficulty;
        private System.Windows.Forms.Label label_DiffValue;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Label label_KeyBindingsLabel;
        private System.Windows.Forms.Label label_UpLabel;
        private System.Windows.Forms.Label label_DownLabel;
        private System.Windows.Forms.Label label_RightLabel;
        private System.Windows.Forms.Label label_LeftLabel;
        private System.Windows.Forms.TextBox textBox_Up;
        private System.Windows.Forms.TextBox textBox_Down;
        private System.Windows.Forms.TextBox textBox_Right;
        private System.Windows.Forms.TextBox textBox_Left;
        private System.Windows.Forms.Button button_Default;
        private System.Windows.Forms.Button button_Arrows;
    }
}