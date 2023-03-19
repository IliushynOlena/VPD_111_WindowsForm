using System.Windows.Forms;

namespace _10_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Clear();   
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage($"New Tab {tabControl1.TabPages.Count + 1} ");

            // 
            // label1
            //
            Label mainlabel = new Label();
            mainlabel.AutoSize = true;
            mainlabel.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            mainlabel.Location = new System.Drawing.Point(441, 256);
            mainlabel.Size = new System.Drawing.Size(670, 159);
            mainlabel.TabIndex = 0;
            mainlabel.Text = "Hello User";
            // 
            // label2
            // 
            Label namelabel = new Label();
            namelabel.AutoSize = true;
            namelabel.Location = new System.Drawing.Point(266, 516);
            namelabel.Size = new System.Drawing.Size(112, 41);
            namelabel.TabIndex = 1;
            namelabel.Text = "Name :";
            // 
            // nameTb
            // 
            //TextBox nameTextBox = new TextBox();
            ListBox nameTextBox = new ListBox();
            nameTextBox.Location = new System.Drawing.Point(454, 510);
            nameTextBox.Name = "nameTb";
            nameTextBox.Size = new System.Drawing.Size(584, 300);
            nameTextBox.TabIndex = 2;
            nameTextBox.ScrollAlwaysVisible = true;
            nameTextBox.HorizontalScrollbar = true;

            nameTextBox.AllowDrop = true;
            nameTextBox.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.Text) || e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    nameTextBox.BackColor = Color.Orange;
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            };
            nameTextBox.DragDrop += (s, e) => {
                if (e.Data.GetDataPresent(DataFormats.Text))
                {
                    string item = e.Data.GetData(DataFormats.Text).ToString();
                    nameTextBox.Items.Add(item);
                }
                else if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
                    {
                        //read from file
                        StreamReader reader = new StreamReader(item);
                        nameTextBox.Items.Add(reader.ReadToEnd());
                        reader.Close();
                    }
                }
                nameTextBox.ResetBackColor();
            };
            // 
            // ClearBtn
            // 
            Button clearButton = new Button();
            clearButton.Location = new System.Drawing.Point(594, 664);
            clearButton.Name = "ClearBtn";
            clearButton.Size = new System.Drawing.Size(251, 90);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            //clearButton.Click += (s, args)=> { nameTextBox.Clear(); };
          

            page.Controls.Add(namelabel);
            page.Controls.Add(nameTextBox);
            page.Controls.Add(mainlabel);
            page.Controls.Add(clearButton);
            page.UseVisualStyleBackColor = true;
            tabControl1.TabPages.Add(page);
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex != -1)
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }
        TextBox GetSelectedTab()
        {
            foreach (var item in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                if (item.Name == "nameTb")
                    return item;
            }
            return null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TextBox tb = GetSelectedTab();
            MessageBox.Show($"Name {tb.Text}");
        }
    }
}