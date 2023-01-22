namespace mashin_hesab_T3ohid
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.btnjam = new System.Windows.Forms.Button();
            this.btnkam = new System.Windows.Forms.Button();
            this.btnzarb = new System.Windows.Forms.Button();
            this.btntagsim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl1.Location = new System.Drawing.Point(186, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "عدد اول :";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl2.Location = new System.Drawing.Point(186, 50);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(58, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "عدد دوم :";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(13, 22);
            this.num1.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(169, 24);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(13, 53);
            this.num2.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(169, 24);
            this.num2.TabIndex = 3;
            // 
            // btnjam
            // 
            this.btnjam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnjam.Font = new System.Drawing.Font("B Nazanin", 39.25F);
            this.btnjam.Location = new System.Drawing.Point(12, 101);
            this.btnjam.Name = "btnjam";
            this.btnjam.Size = new System.Drawing.Size(115, 59);
            this.btnjam.TabIndex = 4;
            this.btnjam.Text = "+";
            this.btnjam.UseVisualStyleBackColor = true;
            this.btnjam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkam
            // 
            this.btnkam.AutoEllipsis = true;
            this.btnkam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnkam.Font = new System.Drawing.Font("B Nazanin", 39.25F);
            this.btnkam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnkam.Location = new System.Drawing.Point(133, 101);
            this.btnkam.Name = "btnkam";
            this.btnkam.Size = new System.Drawing.Size(105, 59);
            this.btnkam.TabIndex = 5;
            this.btnkam.Text = "-";
            this.btnkam.UseVisualStyleBackColor = true;
            this.btnkam.Click += new System.EventHandler(this.btnkam_Click);
            // 
            // btnzarb
            // 
            this.btnzarb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnzarb.Font = new System.Drawing.Font("B Nazanin", 39.25F);
            this.btnzarb.Location = new System.Drawing.Point(12, 166);
            this.btnzarb.Name = "btnzarb";
            this.btnzarb.Size = new System.Drawing.Size(115, 59);
            this.btnzarb.TabIndex = 6;
            this.btnzarb.Text = "*";
            this.btnzarb.UseVisualStyleBackColor = true;
            this.btnzarb.Click += new System.EventHandler(this.btnzarb_Click);
            // 
            // btntagsim
            // 
            this.btntagsim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntagsim.Font = new System.Drawing.Font("B Nazanin", 39.25F);
            this.btntagsim.Location = new System.Drawing.Point(133, 166);
            this.btntagsim.Name = "btntagsim";
            this.btntagsim.Size = new System.Drawing.Size(105, 59);
            this.btntagsim.TabIndex = 7;
            this.btntagsim.Text = "/";
            this.btntagsim.UseVisualStyleBackColor = true;
            this.btntagsim.Click += new System.EventHandler(this.btntagsim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 265);
            this.Controls.Add(this.btntagsim);
            this.Controls.Add(this.btnzarb);
            this.Controls.Add(this.btnkam);
            this.Controls.Add(this.btnjam);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب من";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Button btnjam;
        private System.Windows.Forms.Button btnkam;
        private System.Windows.Forms.Button btnzarb;
        private System.Windows.Forms.Button btntagsim;
    }
}

