namespace _06_AdittionalForms
{
    partial class SecondForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userNameLb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(391, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Second Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 175);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameLb
            // 
            this.userNameLb.AutoSize = true;
            this.userNameLb.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLb.Location = new System.Drawing.Point(391, 259);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(353, 106);
            this.userNameLb.TabIndex = 2;
            this.userNameLb.Text = "Hello, .....";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 175);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show User Name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 690);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userNameLb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userNameLb;
        private System.Windows.Forms.Button button2;
    }
}