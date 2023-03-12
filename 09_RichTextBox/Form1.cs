namespace _09_RichTextBox
{
    public partial class Form1 : Form
    {
     
        string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamily.GenericMonospace, 22, FontStyle.Bold);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.GreenYellow;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent+=2;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent--;
            //richTextBox1.SelectionRightIndent++;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = checkBox1.Checked;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DesktopPath + @"\Doc.rtf", RichTextBoxStreamType.RichText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(DesktopPath + @"\Doc.rtf", RichTextBoxStreamType.RichText);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if ( dialog.ShowDialog() == DialogResult.OK )
                richTextBox1.SelectionFont = dialog.Font;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = toolStripButton2.Checked;
        }

        private void bulletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = bulletToolStripMenuItem.Checked;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = dialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = dialog.Color;
        }
    }
}