namespace _05_Lists
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DellBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.moveRightBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showSelectBtn = new System.Windows.Forms.Button();
            this.removeSelectBtn = new System.Windows.Forms.Button();
            this.deleteSelectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rivne",
            "Lviv",
            "Kyiv",
            "Kharkiv",
            "Odessa"});
            this.comboBox1.Location = new System.Drawing.Point(43, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 327);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rivne",
            "Lviv",
            "Kyiv",
            "Kharkiv",
            "Odessa"});
            this.comboBox2.Location = new System.Drawing.Point(406, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(302, 49);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Rivne",
            "Lviv",
            "Kyiv",
            "Kharkiv",
            "Odessa"});
            this.comboBox3.Location = new System.Drawing.Point(737, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(302, 49);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select your city:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select your city:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select your city:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 142);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderComboBox
            // 
            this.orderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(46, 442);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(401, 49);
            this.orderComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select  order:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(514, 444);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(161, 47);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "Order Price:";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(447, 543);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(320, 108);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add New Order";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DellBtn
            // 
            this.DellBtn.Location = new System.Drawing.Point(447, 713);
            this.DellBtn.Name = "DellBtn";
            this.DellBtn.Size = new System.Drawing.Size(320, 108);
            this.DellBtn.TabIndex = 12;
            this.DellBtn.Text = "Remove Selected Order";
            this.DellBtn.UseVisualStyleBackColor = true;
            this.DellBtn.Click += new System.EventHandler(this.DellBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(447, 864);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(320, 108);
            this.ShowBtn.TabIndex = 13;
            this.ShowBtn.Text = "Show Selected Order";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Purple"});
            this.listBox1.Location = new System.Drawing.Point(1141, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(588, 578);
            this.listBox1.TabIndex = 14;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Purple"});
            this.checkedListBox1.Location = new System.Drawing.Point(1874, 68);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(518, 576);
            this.checkedListBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1643, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 58);
            this.button2.TabIndex = 16;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.Location = new System.Drawing.Point(1745, 312);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(86, 58);
            this.moveRightBtn.TabIndex = 17;
            this.moveRightBtn.Text = "=>";
            this.moveRightBtn.UseVisualStyleBackColor = true;
            this.moveRightBtn.Click += new System.EventHandler(this.moveRightBtn_Click);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.Location = new System.Drawing.Point(1745, 433);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(86, 58);
            this.moveLeftBtn.TabIndex = 18;
            this.moveLeftBtn.Text = "<=";
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.Click += new System.EventHandler(this.moveLeftBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1155, 684);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 47);
            this.textBox1.TabIndex = 19;
            // 
            // showSelectBtn
            // 
            this.showSelectBtn.Location = new System.Drawing.Point(1160, 800);
            this.showSelectBtn.Name = "showSelectBtn";
            this.showSelectBtn.Size = new System.Drawing.Size(302, 134);
            this.showSelectBtn.TabIndex = 20;
            this.showSelectBtn.Text = "Show Selection";
            this.showSelectBtn.UseVisualStyleBackColor = true;
            this.showSelectBtn.Click += new System.EventHandler(this.showSelectBtn_Click);
            // 
            // removeSelectBtn
            // 
            this.removeSelectBtn.Location = new System.Drawing.Point(1511, 800);
            this.removeSelectBtn.Name = "removeSelectBtn";
            this.removeSelectBtn.Size = new System.Drawing.Size(302, 134);
            this.removeSelectBtn.TabIndex = 21;
            this.removeSelectBtn.Text = "Remove Selected Items";
            this.removeSelectBtn.UseVisualStyleBackColor = true;
            this.removeSelectBtn.Click += new System.EventHandler(this.removeSelectBtn_Click);
            // 
            // deleteSelectBtn
            // 
            this.deleteSelectBtn.Location = new System.Drawing.Point(2090, 700);
            this.deleteSelectBtn.Name = "deleteSelectBtn";
            this.deleteSelectBtn.Size = new System.Drawing.Size(302, 134);
            this.deleteSelectBtn.TabIndex = 22;
            this.deleteSelectBtn.Text = "Delete Checked Items";
            this.deleteSelectBtn.UseVisualStyleBackColor = true;
            this.deleteSelectBtn.Click += new System.EventHandler(this.deleteSelectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2460, 1020);
            this.Controls.Add(this.deleteSelectBtn);
            this.Controls.Add(this.removeSelectBtn);
            this.Controls.Add(this.showSelectBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.moveLeftBtn);
            this.Controls.Add(this.moveRightBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.DellBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DellBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button moveRightBtn;
        private System.Windows.Forms.Button moveLeftBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showSelectBtn;
        private System.Windows.Forms.Button removeSelectBtn;
        private System.Windows.Forms.Button deleteSelectBtn;
    }
}
