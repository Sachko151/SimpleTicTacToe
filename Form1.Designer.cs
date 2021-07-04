namespace TicTacToe
{
    partial class Form1
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
            this.grid1 = new System.Windows.Forms.Panel();
            this.grid2 = new System.Windows.Forms.Panel();
            this.grid3 = new System.Windows.Forms.Panel();
            this.grid6 = new System.Windows.Forms.Panel();
            this.grid5 = new System.Windows.Forms.Panel();
            this.grid4 = new System.Windows.Forms.Panel();
            this.grid9 = new System.Windows.Forms.Panel();
            this.grid8 = new System.Windows.Forms.Panel();
            this.grid7 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.BackColor = System.Drawing.Color.White;
            this.grid1.Location = new System.Drawing.Point(1, -1);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(57, 53);
            this.grid1.TabIndex = 0;
            this.grid1.Click += new System.EventHandler(this.grid1_Click);
            // 
            // grid2
            // 
            this.grid2.BackColor = System.Drawing.Color.White;
            this.grid2.Location = new System.Drawing.Point(1, 58);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(57, 53);
            this.grid2.TabIndex = 1;
            this.grid2.Click += new System.EventHandler(this.grid2_Click);
            // 
            // grid3
            // 
            this.grid3.BackColor = System.Drawing.Color.White;
            this.grid3.Location = new System.Drawing.Point(1, 117);
            this.grid3.Name = "grid3";
            this.grid3.Size = new System.Drawing.Size(57, 53);
            this.grid3.TabIndex = 1;
            this.grid3.Click += new System.EventHandler(this.grid3_Click);
            // 
            // grid6
            // 
            this.grid6.BackColor = System.Drawing.Color.White;
            this.grid6.Location = new System.Drawing.Point(64, 117);
            this.grid6.Name = "grid6";
            this.grid6.Size = new System.Drawing.Size(57, 53);
            this.grid6.TabIndex = 4;
            this.grid6.Click += new System.EventHandler(this.grid6_Click);
            // 
            // grid5
            // 
            this.grid5.BackColor = System.Drawing.Color.White;
            this.grid5.Location = new System.Drawing.Point(64, 58);
            this.grid5.Name = "grid5";
            this.grid5.Size = new System.Drawing.Size(57, 53);
            this.grid5.TabIndex = 3;
            this.grid5.Click += new System.EventHandler(this.grid5_Click);
            // 
            // grid4
            // 
            this.grid4.BackColor = System.Drawing.Color.White;
            this.grid4.Location = new System.Drawing.Point(64, -1);
            this.grid4.Name = "grid4";
            this.grid4.Size = new System.Drawing.Size(57, 53);
            this.grid4.TabIndex = 2;
            this.grid4.Click += new System.EventHandler(this.grid4_Click);
            // 
            // grid9
            // 
            this.grid9.BackColor = System.Drawing.Color.White;
            this.grid9.Location = new System.Drawing.Point(127, 117);
            this.grid9.Name = "grid9";
            this.grid9.Size = new System.Drawing.Size(57, 53);
            this.grid9.TabIndex = 4;
            this.grid9.Click += new System.EventHandler(this.grid9_Click);
            // 
            // grid8
            // 
            this.grid8.BackColor = System.Drawing.Color.White;
            this.grid8.Location = new System.Drawing.Point(127, 58);
            this.grid8.Name = "grid8";
            this.grid8.Size = new System.Drawing.Size(57, 53);
            this.grid8.TabIndex = 3;
            this.grid8.Click += new System.EventHandler(this.grid8_Click);
            // 
            // grid7
            // 
            this.grid7.BackColor = System.Drawing.Color.White;
            this.grid7.Location = new System.Drawing.Point(127, -1);
            this.grid7.Name = "grid7";
            this.grid7.Size = new System.Drawing.Size(57, 53);
            this.grid7.TabIndex = 2;
            this.grid7.Click += new System.EventHandler(this.grid7_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Black;
            this.mainPanel.Controls.Add(this.grid6);
            this.mainPanel.Controls.Add(this.grid9);
            this.mainPanel.Controls.Add(this.grid1);
            this.mainPanel.Controls.Add(this.grid2);
            this.mainPanel.Controls.Add(this.grid8);
            this.mainPanel.Controls.Add(this.grid4);
            this.mainPanel.Controls.Add(this.grid7);
            this.mainPanel.Controls.Add(this.grid5);
            this.mainPanel.Controls.Add(this.grid3);
            this.mainPanel.Location = new System.Drawing.Point(46, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(185, 170);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.MouseHover += new System.EventHandler(this.mainPanel_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Turn";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Location = new System.Drawing.Point(310, 78);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(36, 13);
            this.lblPlayerTurn.TabIndex = 7;
            this.lblPlayerTurn.Text = "Player";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(455, 78);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(22, 13);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0-0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Score";
            // 
            // btnResetScore
            // 
            this.btnResetScore.Location = new System.Drawing.Point(19, 238);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(177, 45);
            this.btnResetScore.TabIndex = 10;
            this.btnResetScore.Text = "Reset The Game";
            this.btnResetScore.UseVisualStyleBackColor = true;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(229, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 45);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Player";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreeting.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGreeting.Location = new System.Drawing.Point(264, 134);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 30);
            this.lblGreeting.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 294);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResetScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel grid1;
        private System.Windows.Forms.Panel grid2;
        private System.Windows.Forms.Panel grid3;
        private System.Windows.Forms.Panel grid6;
        private System.Windows.Forms.Panel grid5;
        private System.Windows.Forms.Panel grid4;
        private System.Windows.Forms.Panel grid9;
        private System.Windows.Forms.Panel grid8;
        private System.Windows.Forms.Panel grid7;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGreeting;
    }
}

