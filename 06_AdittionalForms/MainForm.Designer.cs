namespace _06_AdittionalForms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.openLoginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(572, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Window";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(515, 190);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Second Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(331, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(572, 164);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(577, 47);
            this.nameTb.TabIndex = 3;
            // 
            // openLoginBtn
            // 
            this.openLoginBtn.Location = new System.Drawing.Point(870, 573);
            this.openLoginBtn.Name = "openLoginBtn";
            this.openLoginBtn.Size = new System.Drawing.Size(515, 190);
            this.openLoginBtn.TabIndex = 4;
            this.openLoginBtn.Text = "Open Login Form";
            this.openLoginBtn.UseVisualStyleBackColor = true;
            this.openLoginBtn.Click += new System.EventHandler(this.openLoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password :";
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(572, 303);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(158, 41);
            this.loginLb.TabIndex = 7;
            this.loginLb.Text = "....................";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(572, 426);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(151, 41);
            this.passwordLb.TabIndex = 8;
            this.passwordLb.Text = "...................";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 885);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openLoginBtn);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button openLoginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label passwordLb;
    }
}
