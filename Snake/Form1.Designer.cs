namespace Snake
{
    partial class aForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aForm));
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.aScoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aRecordLabel = new System.Windows.Forms.Label();
            this.aRestartButton = new System.Windows.Forms.Label();
            this.aSegment4 = new System.Windows.Forms.PictureBox();
            this.aSegment3 = new System.Windows.Forms.PictureBox();
            this.aSnakeHead = new System.Windows.Forms.PictureBox();
            this.aSegment2 = new System.Windows.Forms.PictureBox();
            this.aSegment1 = new System.Windows.Forms.PictureBox();
            this.aFood = new System.Windows.Forms.PictureBox();
            this.aBox = new System.Windows.Forms.PictureBox();
            this.aQuitButton = new System.Windows.Forms.Label();
            this.aBorderLabel = new System.Windows.Forms.Label();
            this.aSpeedLabel = new System.Windows.Forms.Label();
            this.aAddSpeed = new System.Windows.Forms.Label();
            this.aSubtractSpeed = new System.Windows.Forms.Label();
            this.aTimeLeft = new System.Windows.Forms.Label();
            this.aTimeLeftLabel = new System.Windows.Forms.Label();
            this.aModeLabel = new System.Windows.Forms.Label();
            this.aTimeModeTimer = new System.Windows.Forms.Timer(this.components);
            this.aPauseLabel = new System.Windows.Forms.Label();
            this.aSuperFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aSegment4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSegment3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSnakeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSegment2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSegment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSuperFood)).BeginInit();
            this.SuspendLayout();
            // 
            // aTimer
            // 
            this.aTimer.Interval = 155;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Record: ";
            // 
            // aScoreLabel
            // 
            this.aScoreLabel.AutoSize = true;
            this.aScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aScoreLabel.Location = new System.Drawing.Point(928, 54);
            this.aScoreLabel.Name = "aScoreLabel";
            this.aScoreLabel.Size = new System.Drawing.Size(34, 39);
            this.aScoreLabel.TabIndex = 9;
            this.aScoreLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Score: ";
            // 
            // aRecordLabel
            // 
            this.aRecordLabel.AutoSize = true;
            this.aRecordLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRecordLabel.Location = new System.Drawing.Point(928, 15);
            this.aRecordLabel.Name = "aRecordLabel";
            this.aRecordLabel.Size = new System.Drawing.Size(34, 39);
            this.aRecordLabel.TabIndex = 11;
            this.aRecordLabel.Text = "0";
            // 
            // aRestartButton
            // 
            this.aRestartButton.AutoSize = true;
            this.aRestartButton.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRestartButton.Location = new System.Drawing.Point(774, 159);
            this.aRestartButton.Name = "aRestartButton";
            this.aRestartButton.Size = new System.Drawing.Size(162, 53);
            this.aRestartButton.TabIndex = 12;
            this.aRestartButton.Text = "Restart";
            this.aRestartButton.Visible = false;
            this.aRestartButton.Click += new System.EventHandler(this.aRestartButton_Click);
            this.aRestartButton.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.aRestartButton.MouseLeave += new System.EventHandler(this.MouseLeaves);
            // 
            // aSegment4
            // 
            this.aSegment4.BackColor = System.Drawing.Color.Cornsilk;
            this.aSegment4.Image = global::Snake.Properties.Resources.endUp;
            this.aSegment4.Location = new System.Drawing.Point(335, 365);
            this.aSegment4.Margin = new System.Windows.Forms.Padding(0);
            this.aSegment4.Name = "aSegment4";
            this.aSegment4.Size = new System.Drawing.Size(20, 20);
            this.aSegment4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aSegment4.TabIndex = 5;
            this.aSegment4.TabStop = false;
            // 
            // aSegment3
            // 
            this.aSegment3.BackColor = System.Drawing.Color.Cornsilk;
            this.aSegment3.Image = global::Snake.Properties.Resources.tailVertical;
            this.aSegment3.Location = new System.Drawing.Point(335, 345);
            this.aSegment3.Margin = new System.Windows.Forms.Padding(0);
            this.aSegment3.Name = "aSegment3";
            this.aSegment3.Size = new System.Drawing.Size(20, 20);
            this.aSegment3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aSegment3.TabIndex = 4;
            this.aSegment3.TabStop = false;
            // 
            // aSnakeHead
            // 
            this.aSnakeHead.BackColor = System.Drawing.Color.Cornsilk;
            this.aSnakeHead.Image = global::Snake.Properties.Resources.headUp;
            this.aSnakeHead.Location = new System.Drawing.Point(335, 285);
            this.aSnakeHead.Margin = new System.Windows.Forms.Padding(0);
            this.aSnakeHead.Name = "aSnakeHead";
            this.aSnakeHead.Size = new System.Drawing.Size(20, 20);
            this.aSnakeHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aSnakeHead.TabIndex = 6;
            this.aSnakeHead.TabStop = false;
            // 
            // aSegment2
            // 
            this.aSegment2.BackColor = System.Drawing.Color.Cornsilk;
            this.aSegment2.Image = global::Snake.Properties.Resources.tailVertical;
            this.aSegment2.Location = new System.Drawing.Point(335, 325);
            this.aSegment2.Margin = new System.Windows.Forms.Padding(0);
            this.aSegment2.Name = "aSegment2";
            this.aSegment2.Size = new System.Drawing.Size(20, 20);
            this.aSegment2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aSegment2.TabIndex = 3;
            this.aSegment2.TabStop = false;
            // 
            // aSegment1
            // 
            this.aSegment1.BackColor = System.Drawing.Color.Cornsilk;
            this.aSegment1.Image = global::Snake.Properties.Resources.tailVertical;
            this.aSegment1.Location = new System.Drawing.Point(335, 305);
            this.aSegment1.Margin = new System.Windows.Forms.Padding(0);
            this.aSegment1.Name = "aSegment1";
            this.aSegment1.Size = new System.Drawing.Size(20, 20);
            this.aSegment1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aSegment1.TabIndex = 2;
            this.aSegment1.TabStop = false;
            // 
            // aFood
            // 
            this.aFood.BackColor = System.Drawing.Color.Cornsilk;
            this.aFood.Image = ((System.Drawing.Image)(resources.GetObject("aFood.Image")));
            this.aFood.Location = new System.Drawing.Point(521, 326);
            this.aFood.Margin = new System.Windows.Forms.Padding(0);
            this.aFood.Name = "aFood";
            this.aFood.Size = new System.Drawing.Size(22, 22);
            this.aFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aFood.TabIndex = 7;
            this.aFood.TabStop = false;
            this.aFood.Visible = false;
            // 
            // aBox
            // 
            this.aBox.BackColor = System.Drawing.Color.Cornsilk;
            this.aBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aBox.Location = new System.Drawing.Point(10, 10);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(650, 650);
            this.aBox.TabIndex = 0;
            this.aBox.TabStop = false;
            // 
            // aQuitButton
            // 
            this.aQuitButton.AutoSize = true;
            this.aQuitButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aQuitButton.Location = new System.Drawing.Point(774, 591);
            this.aQuitButton.Name = "aQuitButton";
            this.aQuitButton.Size = new System.Drawing.Size(78, 39);
            this.aQuitButton.TabIndex = 13;
            this.aQuitButton.Text = "Quit";
            this.aQuitButton.Click += new System.EventHandler(this.aQuitButton_Click);
            this.aQuitButton.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.aQuitButton.MouseLeave += new System.EventHandler(this.MouseLeaves);
            // 
            // aBorderLabel
            // 
            this.aBorderLabel.AutoSize = true;
            this.aBorderLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBorderLabel.Location = new System.Drawing.Point(774, 225);
            this.aBorderLabel.Name = "aBorderLabel";
            this.aBorderLabel.Size = new System.Drawing.Size(200, 39);
            this.aBorderLabel.TabIndex = 14;
            this.aBorderLabel.Text = "Borders: YES";
            this.aBorderLabel.Click += new System.EventHandler(this.aBorderLabel_Click);
            this.aBorderLabel.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.aBorderLabel.MouseLeave += new System.EventHandler(this.MouseLeaves);
            // 
            // aSpeedLabel
            // 
            this.aSpeedLabel.AutoSize = true;
            this.aSpeedLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSpeedLabel.Location = new System.Drawing.Point(774, 280);
            this.aSpeedLabel.Name = "aSpeedLabel";
            this.aSpeedLabel.Size = new System.Drawing.Size(140, 39);
            this.aSpeedLabel.TabIndex = 15;
            this.aSpeedLabel.Text = "Speed: 5";
            // 
            // aAddSpeed
            // 
            this.aAddSpeed.AutoSize = true;
            this.aAddSpeed.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAddSpeed.Location = new System.Drawing.Point(974, 268);
            this.aAddSpeed.Name = "aAddSpeed";
            this.aAddSpeed.Size = new System.Drawing.Size(46, 53);
            this.aAddSpeed.TabIndex = 16;
            this.aAddSpeed.Text = "+";
            this.aAddSpeed.Click += new System.EventHandler(this.aAddSpeed_Click);
            this.aAddSpeed.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.aAddSpeed.MouseLeave += new System.EventHandler(this.MouseLeaves);
            // 
            // aSubtractSpeed
            // 
            this.aSubtractSpeed.AutoSize = true;
            this.aSubtractSpeed.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSubtractSpeed.Location = new System.Drawing.Point(932, 268);
            this.aSubtractSpeed.Name = "aSubtractSpeed";
            this.aSubtractSpeed.Size = new System.Drawing.Size(46, 53);
            this.aSubtractSpeed.TabIndex = 17;
            this.aSubtractSpeed.Text = "-";
            this.aSubtractSpeed.Click += new System.EventHandler(this.aSubtractSpeed_Click);
            this.aSubtractSpeed.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.aSubtractSpeed.MouseLeave += new System.EventHandler(this.MouseLeaves);
            // 
            // aTimeLeft
            // 
            this.aTimeLeft.AutoSize = true;
            this.aTimeLeft.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTimeLeft.Location = new System.Drawing.Point(928, 93);
            this.aTimeLeft.Name = "aTimeLeft";
            this.aTimeLeft.Size = new System.Drawing.Size(92, 39);
            this.aTimeLeft.TabIndex = 18;
            this.aTimeLeft.Text = "0:30 ";
            // 
            // aTimeLeftLabel
            // 
            this.aTimeLeftLabel.AutoSize = true;
            this.aTimeLeftLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTimeLeftLabel.Location = new System.Drawing.Point(753, 93);
            this.aTimeLeftLabel.Name = "aTimeLeftLabel";
            this.aTimeLeftLabel.Size = new System.Drawing.Size(169, 39);
            this.aTimeLeftLabel.TabIndex = 19;
            this.aTimeLeftLabel.Text = "Time left: ";
            // 
            // aModeLabel
            // 
            this.aModeLabel.AutoSize = true;
            this.aModeLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aModeLabel.Location = new System.Drawing.Point(774, 335);
            this.aModeLabel.Name = "aModeLabel";
            this.aModeLabel.Size = new System.Drawing.Size(204, 39);
            this.aModeLabel.TabIndex = 20;
            this.aModeLabel.Text = "Mode: Classic";
            this.aModeLabel.Click += new System.EventHandler(this.aModeLabel_Click);
            this.aModeLabel.MouseEnter += new System.EventHandler(this.MouseEnters);
            this.aModeLabel.MouseLeave += new System.EventHandler(this.MouseLeaves);
            // 
            // aTimeModeTimer
            // 
            this.aTimeModeTimer.Interval = 1000;
            this.aTimeModeTimer.Tick += new System.EventHandler(this.aTimeModeTimer_Tick);
            // 
            // aPauseLabel
            // 
            this.aPauseLabel.AutoSize = true;
            this.aPauseLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPauseLabel.Location = new System.Drawing.Point(756, 389);
            this.aPauseLabel.Name = "aPauseLabel";
            this.aPauseLabel.Size = new System.Drawing.Size(110, 21);
            this.aPauseLabel.TabIndex = 21;
            this.aPauseLabel.Text = "Space (Pause)";
            this.aPauseLabel.Visible = false;
            // 
            // aSuperFood
            // 
            this.aSuperFood.BackColor = System.Drawing.Color.Cornsilk;
            this.aSuperFood.Image = global::Snake.Properties.Resources.superfood;
            this.aSuperFood.Location = new System.Drawing.Point(460, 225);
            this.aSuperFood.Margin = new System.Windows.Forms.Padding(0);
            this.aSuperFood.Name = "aSuperFood";
            this.aSuperFood.Size = new System.Drawing.Size(22, 22);
            this.aSuperFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aSuperFood.TabIndex = 22;
            this.aSuperFood.TabStop = false;
            this.aSuperFood.Visible = false;
            // 
            // aForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 693);
            this.Controls.Add(this.aSuperFood);
            this.Controls.Add(this.aPauseLabel);
            this.Controls.Add(this.aModeLabel);
            this.Controls.Add(this.aTimeLeftLabel);
            this.Controls.Add(this.aTimeLeft);
            this.Controls.Add(this.aSubtractSpeed);
            this.Controls.Add(this.aAddSpeed);
            this.Controls.Add(this.aSpeedLabel);
            this.Controls.Add(this.aBorderLabel);
            this.Controls.Add(this.aQuitButton);
            this.Controls.Add(this.aSegment4);
            this.Controls.Add(this.aSegment3);
            this.Controls.Add(this.aSnakeHead);
            this.Controls.Add(this.aSegment2);
            this.Controls.Add(this.aSegment1);
            this.Controls.Add(this.aRestartButton);
            this.Controls.Add(this.aRecordLabel);
            this.Controls.Add(this.aScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aFood);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "aForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.aForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.aSegment4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSegment3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSnakeHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSegment2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSegment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSuperFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.PictureBox aSegment1;
        private System.Windows.Forms.PictureBox aSegment2;
        private System.Windows.Forms.PictureBox aSegment3;
        private System.Windows.Forms.PictureBox aSegment4;
        private System.Windows.Forms.PictureBox aSnakeHead;
        private System.Windows.Forms.PictureBox aFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aScoreLabel;
        public System.Windows.Forms.PictureBox aBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aRecordLabel;
        private System.Windows.Forms.Label aRestartButton;
        private System.Windows.Forms.Label aQuitButton;
        private System.Windows.Forms.Label aBorderLabel;
        private System.Windows.Forms.Label aSpeedLabel;
        private System.Windows.Forms.Label aAddSpeed;
        private System.Windows.Forms.Label aSubtractSpeed;
        private System.Windows.Forms.Label aTimeLeft;
        private System.Windows.Forms.Label aTimeLeftLabel;
        private System.Windows.Forms.Label aModeLabel;
        private System.Windows.Forms.Timer aTimeModeTimer;
        private System.Windows.Forms.Label aPauseLabel;
        private System.Windows.Forms.PictureBox aSuperFood;
    }
}

