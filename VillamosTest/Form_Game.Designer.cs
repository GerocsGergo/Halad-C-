
namespace VillamosTest
{
    partial class Form_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game));
            this.panel_Map = new System.Windows.Forms.Panel();
            this.pictureBox_DownWall = new System.Windows.Forms.PictureBox();
            this.pictureBox_RightWall = new System.Windows.Forms.PictureBox();
            this.pictureBox_LeftWall = new System.Windows.Forms.PictureBox();
            this.pictureBox_Head = new System.Windows.Forms.PictureBox();
            this.pictureBox_TopWall = new System.Windows.Forms.PictureBox();
            this.label_ScoreLabel = new System.Windows.Forms.Label();
            this.timer_Timer = new System.Windows.Forms.Timer(this.components);
            this.label_Timer = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.panel_ScoreBoard = new System.Windows.Forms.Panel();
            this.label_Difficulty = new System.Windows.Forms.Label();
            this.label_DifficultyLabel = new System.Windows.Forms.Label();
            this.label_FuelLabel = new System.Windows.Forms.Label();
            this.progressBar_Fuel = new System.Windows.Forms.ProgressBar();
            this.label_Farmer = new System.Windows.Forms.Label();
            this.label_Corn = new System.Windows.Forms.Label();
            this.label_Wheat = new System.Windows.Forms.Label();
            this.label_FarmerLabel = new System.Windows.Forms.Label();
            this.label_CornLabel = new System.Windows.Forms.Label();
            this.label_WheatLabel = new System.Windows.Forms.Label();
            this.label_TimeLabel = new System.Windows.Forms.Label();
            this.panel_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DownWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TopWall)).BeginInit();
            this.panel_ScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Map
            // 
            this.panel_Map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.panel_Map.Controls.Add(this.pictureBox_DownWall);
            this.panel_Map.Controls.Add(this.pictureBox_RightWall);
            this.panel_Map.Controls.Add(this.pictureBox_LeftWall);
            this.panel_Map.Controls.Add(this.pictureBox_Head);
            this.panel_Map.Controls.Add(this.pictureBox_TopWall);
            this.panel_Map.Location = new System.Drawing.Point(30, 30);
            this.panel_Map.Name = "panel_Map";
            this.panel_Map.Size = new System.Drawing.Size(800, 600);
            this.panel_Map.TabIndex = 0;
            // 
            // pictureBox_DownWall
            // 
            this.pictureBox_DownWall.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_DownWall.Image = global::VillamosTest.Properties.Resources.Border;
            this.pictureBox_DownWall.Location = new System.Drawing.Point(0, 590);
            this.pictureBox_DownWall.Name = "pictureBox_DownWall";
            this.pictureBox_DownWall.Size = new System.Drawing.Size(800, 10);
            this.pictureBox_DownWall.TabIndex = 5;
            this.pictureBox_DownWall.TabStop = false;
            // 
            // pictureBox_RightWall
            // 
            this.pictureBox_RightWall.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_RightWall.Image = global::VillamosTest.Properties.Resources.BorderRotated;
            this.pictureBox_RightWall.Location = new System.Drawing.Point(790, 0);
            this.pictureBox_RightWall.Name = "pictureBox_RightWall";
            this.pictureBox_RightWall.Size = new System.Drawing.Size(10, 600);
            this.pictureBox_RightWall.TabIndex = 3;
            this.pictureBox_RightWall.TabStop = false;
            // 
            // pictureBox_LeftWall
            // 
            this.pictureBox_LeftWall.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_LeftWall.Image = global::VillamosTest.Properties.Resources.BorderRotated1;
            this.pictureBox_LeftWall.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_LeftWall.Name = "pictureBox_LeftWall";
            this.pictureBox_LeftWall.Size = new System.Drawing.Size(10, 600);
            this.pictureBox_LeftWall.TabIndex = 4;
            this.pictureBox_LeftWall.TabStop = false;
            // 
            // pictureBox_Head
            // 
            this.pictureBox_Head.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Head.Image")));
            this.pictureBox_Head.Location = new System.Drawing.Point(86, 421);
            this.pictureBox_Head.Name = "pictureBox_Head";
            this.pictureBox_Head.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_Head.TabIndex = 1;
            this.pictureBox_Head.TabStop = false;
            this.pictureBox_Head.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Head_Paint);
            // 
            // pictureBox_TopWall
            // 
            this.pictureBox_TopWall.BackColor = System.Drawing.Color.Lime;
            this.pictureBox_TopWall.Image = global::VillamosTest.Properties.Resources.Border;
            this.pictureBox_TopWall.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_TopWall.Name = "pictureBox_TopWall";
            this.pictureBox_TopWall.Size = new System.Drawing.Size(810, 10);
            this.pictureBox_TopWall.TabIndex = 2;
            this.pictureBox_TopWall.TabStop = false;
            // 
            // label_ScoreLabel
            // 
            this.label_ScoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_ScoreLabel.Location = new System.Drawing.Point(20, 75);
            this.label_ScoreLabel.Name = "label_ScoreLabel";
            this.label_ScoreLabel.Size = new System.Drawing.Size(101, 20);
            this.label_ScoreLabel.TabIndex = 1;
            this.label_ScoreLabel.Text = "Score:";
            // 
            // timer_Timer
            // 
            this.timer_Timer.Tick += new System.EventHandler(this.timer_Timer_Tick);
            // 
            // label_Timer
            // 
            this.label_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_Timer.Location = new System.Drawing.Point(127, 25);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(50, 20);
            this.label_Timer.TabIndex = 3;
            this.label_Timer.Text = "Time";
            // 
            // label_Score
            // 
            this.label_Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_Score.Location = new System.Drawing.Point(127, 75);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(50, 20);
            this.label_Score.TabIndex = 4;
            this.label_Score.Text = "0";
            // 
            // panel_ScoreBoard
            // 
            this.panel_ScoreBoard.BackgroundImage = global::VillamosTest.Properties.Resources.ScoreHatter;
            this.panel_ScoreBoard.Controls.Add(this.label_Difficulty);
            this.panel_ScoreBoard.Controls.Add(this.label_DifficultyLabel);
            this.panel_ScoreBoard.Controls.Add(this.label_FuelLabel);
            this.panel_ScoreBoard.Controls.Add(this.progressBar_Fuel);
            this.panel_ScoreBoard.Controls.Add(this.label_Farmer);
            this.panel_ScoreBoard.Controls.Add(this.label_Corn);
            this.panel_ScoreBoard.Controls.Add(this.label_Wheat);
            this.panel_ScoreBoard.Controls.Add(this.label_FarmerLabel);
            this.panel_ScoreBoard.Controls.Add(this.label_CornLabel);
            this.panel_ScoreBoard.Controls.Add(this.label_WheatLabel);
            this.panel_ScoreBoard.Controls.Add(this.label_TimeLabel);
            this.panel_ScoreBoard.Controls.Add(this.label_Timer);
            this.panel_ScoreBoard.Controls.Add(this.label_ScoreLabel);
            this.panel_ScoreBoard.Controls.Add(this.label_Score);
            this.panel_ScoreBoard.Location = new System.Drawing.Point(860, 30);
            this.panel_ScoreBoard.Name = "panel_ScoreBoard";
            this.panel_ScoreBoard.Size = new System.Drawing.Size(200, 600);
            this.panel_ScoreBoard.TabIndex = 6;
            // 
            // label_Difficulty
            // 
            this.label_Difficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_Difficulty.Location = new System.Drawing.Point(92, 347);
            this.label_Difficulty.Name = "label_Difficulty";
            this.label_Difficulty.Size = new System.Drawing.Size(85, 25);
            this.label_Difficulty.TabIndex = 17;
            this.label_Difficulty.Text = "null";
            // 
            // label_DifficultyLabel
            // 
            this.label_DifficultyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_DifficultyLabel.Location = new System.Drawing.Point(20, 347);
            this.label_DifficultyLabel.Name = "label_DifficultyLabel";
            this.label_DifficultyLabel.Size = new System.Drawing.Size(73, 25);
            this.label_DifficultyLabel.TabIndex = 16;
            this.label_DifficultyLabel.Text = "Difficulty:";
            // 
            // label_FuelLabel
            // 
            this.label_FuelLabel.AutoSize = true;
            this.label_FuelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_FuelLabel.Location = new System.Drawing.Point(20, 272);
            this.label_FuelLabel.Name = "label_FuelLabel";
            this.label_FuelLabel.Size = new System.Drawing.Size(39, 20);
            this.label_FuelLabel.TabIndex = 15;
            this.label_FuelLabel.Text = "Fuel:";
            // 
            // progressBar_Fuel
            // 
            this.progressBar_Fuel.Location = new System.Drawing.Point(20, 295);
            this.progressBar_Fuel.Name = "progressBar_Fuel";
            this.progressBar_Fuel.Size = new System.Drawing.Size(157, 29);
            this.progressBar_Fuel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Fuel.TabIndex = 14;
            this.progressBar_Fuel.Value = 100;
            // 
            // label_Farmer
            // 
            this.label_Farmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_Farmer.Location = new System.Drawing.Point(127, 225);
            this.label_Farmer.Name = "label_Farmer";
            this.label_Farmer.Size = new System.Drawing.Size(50, 20);
            this.label_Farmer.TabIndex = 12;
            this.label_Farmer.Text = "0";
            // 
            // label_Corn
            // 
            this.label_Corn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_Corn.Location = new System.Drawing.Point(127, 175);
            this.label_Corn.Name = "label_Corn";
            this.label_Corn.Size = new System.Drawing.Size(50, 20);
            this.label_Corn.TabIndex = 11;
            this.label_Corn.Text = "0";
            // 
            // label_Wheat
            // 
            this.label_Wheat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_Wheat.Location = new System.Drawing.Point(127, 125);
            this.label_Wheat.Name = "label_Wheat";
            this.label_Wheat.Size = new System.Drawing.Size(50, 20);
            this.label_Wheat.TabIndex = 10;
            this.label_Wheat.Text = "0";
            // 
            // label_FarmerLabel
            // 
            this.label_FarmerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_FarmerLabel.Location = new System.Drawing.Point(20, 225);
            this.label_FarmerLabel.Name = "label_FarmerLabel";
            this.label_FarmerLabel.Size = new System.Drawing.Size(101, 25);
            this.label_FarmerLabel.TabIndex = 9;
            this.label_FarmerLabel.Text = "Farmer:";
            // 
            // label_CornLabel
            // 
            this.label_CornLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_CornLabel.Location = new System.Drawing.Point(20, 175);
            this.label_CornLabel.Name = "label_CornLabel";
            this.label_CornLabel.Size = new System.Drawing.Size(101, 25);
            this.label_CornLabel.TabIndex = 8;
            this.label_CornLabel.Text = "Corn:";
            // 
            // label_WheatLabel
            // 
            this.label_WheatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_WheatLabel.Location = new System.Drawing.Point(20, 125);
            this.label_WheatLabel.Name = "label_WheatLabel";
            this.label_WheatLabel.Size = new System.Drawing.Size(101, 25);
            this.label_WheatLabel.TabIndex = 7;
            this.label_WheatLabel.Text = "Wheat:";
            // 
            // label_TimeLabel
            // 
            this.label_TimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_TimeLabel.Location = new System.Drawing.Point(20, 25);
            this.label_TimeLabel.Name = "label_TimeLabel";
            this.label_TimeLabel.Size = new System.Drawing.Size(101, 20);
            this.label_TimeLabel.TabIndex = 6;
            this.label_TimeLabel.Text = "Elapsed Time:";
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel_ScoreBoard);
            this.Controls.Add(this.panel_Map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Game";
            this.Text = "Combine";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Game_KeyDown);
            this.panel_Map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DownWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TopWall)).EndInit();
            this.panel_ScoreBoard.ResumeLayout(false);
            this.panel_ScoreBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Map;
        private System.Windows.Forms.PictureBox pictureBox_Head;
        private System.Windows.Forms.PictureBox pictureBox_TopWall;
        private System.Windows.Forms.PictureBox pictureBox_RightWall;
        private System.Windows.Forms.PictureBox pictureBox_LeftWall;
        private System.Windows.Forms.PictureBox pictureBox_DownWall;
        private System.Windows.Forms.Label label_ScoreLabel;
        private System.Windows.Forms.Timer timer_Timer;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Panel panel_ScoreBoard;
        private System.Windows.Forms.Label label_TimeLabel;
        private System.Windows.Forms.Label label_Corn;
        private System.Windows.Forms.Label label_Wheat;
        private System.Windows.Forms.Label label_FarmerLabel;
        private System.Windows.Forms.Label label_CornLabel;
        private System.Windows.Forms.Label label_WheatLabel;
        private System.Windows.Forms.Label label_Farmer;
        private System.Windows.Forms.ProgressBar progressBar_Fuel;
        private System.Windows.Forms.Label label_FuelLabel;
        private System.Windows.Forms.Label label_Difficulty;
        private System.Windows.Forms.Label label_DifficultyLabel;
    }
}