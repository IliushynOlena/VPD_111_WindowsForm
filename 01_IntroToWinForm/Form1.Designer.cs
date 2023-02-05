namespace _01_IntroToWinForm
{
    partial class Form1
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
            this.MessageBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leftBtn = new System.Windows.Forms.Button();
            this.CSharpBtn = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageBtn
            // 
            this.MessageBtn.BackColor = System.Drawing.Color.Lime;
            this.MessageBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MessageBtn.Location = new System.Drawing.Point(234, 228);
            this.MessageBtn.Name = "MessageBtn";
            this.MessageBtn.Size = new System.Drawing.Size(431, 241);
            this.MessageBtn.TabIndex = 0;
            this.MessageBtn.Text = "Натисни";
            this.MessageBtn.UseVisualStyleBackColor = false;
            this.MessageBtn.Click += new System.EventHandler(this.MessageBtn_Click);
            this.MessageBtn.MouseEnter += new System.EventHandler(this.MessageBtn_MouseEnter);
            this.MessageBtn.MouseLeave += new System.EventHandler(this.MessageBtn_MouseLeave);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Blue;
            this.exitBtn.Location = new System.Drawing.Point(967, 228);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(431, 241);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Вихід";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 26.1F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(475, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 126);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello Windows Form";
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(258, 650);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(188, 58);
            this.leftBtn.TabIndex = 3;
            this.leftBtn.Text = "Move Left";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // CSharpBtn
            // 
            this.CSharpBtn.Location = new System.Drawing.Point(763, 650);
            this.CSharpBtn.Name = "CSharpBtn";
            this.CSharpBtn.Size = new System.Drawing.Size(70, 70);
            this.CSharpBtn.TabIndex = 4;
            this.CSharpBtn.Text = "C#";
            this.CSharpBtn.UseVisualStyleBackColor = true;
            this.CSharpBtn.Click += new System.EventHandler(this.CSharpBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(1116, 650);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(188, 58);
            this.rightBtn.TabIndex = 5;
            this.rightBtn.Text = "Move Right";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(783, 810);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(188, 58);
            this.testBtn.TabIndex = 6;
            this.testBtn.Text = "button1";
            this.testBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 1046);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.CSharpBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.MessageBtn);
            this.Name = "Form1";
            this.Text = "Натисни";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MessageBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button CSharpBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button testBtn;
    }
}
