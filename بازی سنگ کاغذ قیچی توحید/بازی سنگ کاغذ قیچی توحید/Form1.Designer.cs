namespace بازی_سنگ_کاغذ_قیچی_توحید
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
            this.sanj = new System.Windows.Forms.Button();
            this.kagaz = new System.Windows.Forms.Button();
            this.geychi = new System.Windows.Forms.Button();
            this.lblScoreBot = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.ChoseBot = new System.Windows.Forms.Label();
            this.ChosePlayer = new System.Windows.Forms.Label();
            this.lblwin = new System.Windows.Forms.Label();
            this.scorebot = new System.Windows.Forms.Label();
            this.scoreplyr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sanj
            // 
            this.sanj.Location = new System.Drawing.Point(12, 212);
            this.sanj.Name = "sanj";
            this.sanj.Size = new System.Drawing.Size(75, 23);
            this.sanj.TabIndex = 0;
            this.sanj.Text = "سنگ";
            this.sanj.UseVisualStyleBackColor = true;
            this.sanj.Click += new System.EventHandler(this.sanj_Click);
            // 
            // kagaz
            // 
            this.kagaz.Location = new System.Drawing.Point(114, 212);
            this.kagaz.Name = "kagaz";
            this.kagaz.Size = new System.Drawing.Size(75, 23);
            this.kagaz.TabIndex = 1;
            this.kagaz.Text = "کاغذ";
            this.kagaz.UseVisualStyleBackColor = true;
            this.kagaz.Click += new System.EventHandler(this.kagaz_Click);
            // 
            // geychi
            // 
            this.geychi.Location = new System.Drawing.Point(218, 212);
            this.geychi.Name = "geychi";
            this.geychi.Size = new System.Drawing.Size(75, 23);
            this.geychi.TabIndex = 2;
            this.geychi.Text = "قیچی";
            this.geychi.UseVisualStyleBackColor = true;
            this.geychi.Click += new System.EventHandler(this.geychi_Click);
            // 
            // lblScoreBot
            // 
            this.lblScoreBot.AutoSize = true;
            this.lblScoreBot.Location = new System.Drawing.Point(215, 92);
            this.lblScoreBot.Name = "lblScoreBot";
            this.lblScoreBot.Size = new System.Drawing.Size(65, 13);
            this.lblScoreBot.TabIndex = 3;
            this.lblScoreBot.Text = "امتیاز ربات : ";
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.Location = new System.Drawing.Point(218, 136);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(62, 13);
            this.lblScorePlayer.TabIndex = 4;
            this.lblScorePlayer.Text = "امتیاز شما : ";
            // 
            // ChoseBot
            // 
            this.ChoseBot.AutoSize = true;
            this.ChoseBot.Location = new System.Drawing.Point(48, 92);
            this.ChoseBot.Name = "ChoseBot";
            this.ChoseBot.Size = new System.Drawing.Size(130, 13);
            this.ChoseBot.TabIndex = 5;
            this.ChoseBot.Text = "انتخاب ربات : فعلا هیچکدام";
            // 
            // ChosePlayer
            // 
            this.ChosePlayer.AutoSize = true;
            this.ChosePlayer.Location = new System.Drawing.Point(71, 136);
            this.ChosePlayer.Name = "ChosePlayer";
            this.ChosePlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChosePlayer.Size = new System.Drawing.Size(64, 13);
            this.ChosePlayer.TabIndex = 6;
            this.ChosePlayer.Text = "انتخاب شما :";
            // 
            // lblwin
            // 
            this.lblwin.AutoSize = true;
            this.lblwin.Location = new System.Drawing.Point(105, 45);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(0, 13);
            this.lblwin.TabIndex = 7;
            // 
            // scorebot
            // 
            this.scorebot.AutoSize = true;
            this.scorebot.Location = new System.Drawing.Point(196, 92);
            this.scorebot.Name = "scorebot";
            this.scorebot.Size = new System.Drawing.Size(13, 13);
            this.scorebot.TabIndex = 8;
            this.scorebot.Text = "0";
            // 
            // scoreplyr
            // 
            this.scoreplyr.AutoSize = true;
            this.scoreplyr.Location = new System.Drawing.Point(196, 136);
            this.scoreplyr.Name = "scoreplyr";
            this.scoreplyr.Size = new System.Drawing.Size(13, 13);
            this.scoreplyr.TabIndex = 9;
            this.scoreplyr.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 306);
            this.Controls.Add(this.scoreplyr);
            this.Controls.Add(this.scorebot);
            this.Controls.Add(this.lblwin);
            this.Controls.Add(this.ChosePlayer);
            this.Controls.Add(this.ChoseBot);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblScoreBot);
            this.Controls.Add(this.geychi);
            this.Controls.Add(this.kagaz);
            this.Controls.Add(this.sanj);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sanj;
        private System.Windows.Forms.Button kagaz;
        private System.Windows.Forms.Button geychi;
        private System.Windows.Forms.Label lblScoreBot;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label ChoseBot;
        private System.Windows.Forms.Label ChosePlayer;
        private System.Windows.Forms.Label lblwin;
        private System.Windows.Forms.Label scorebot;
        private System.Windows.Forms.Label scoreplyr;
    }
}

