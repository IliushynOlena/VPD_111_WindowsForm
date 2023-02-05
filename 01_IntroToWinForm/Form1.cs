using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_IntroToWinForm
{
    public partial class Form1 : Form
    {
        Point startLocation;
        Random random ;
        public Form1()
        {
            InitializeComponent();
            startLocation = CSharpBtn.Location;
            random = new Random();
        }
           
        private void MessageBtn_MouseEnter(object sender, EventArgs e)
        {
            random.Next(this.Height);
            MessageBtn.BackColor = Color.Green;
        }

        private void MessageBtn_MouseLeave(object sender, EventArgs e)
        {
            MessageBtn.BackColor = Color.Lime;
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Windows Form", "Congratilation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { this.Close(); }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point(CSharpBtn.Location.X - 5, CSharpBtn.Location.Y); 
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point(CSharpBtn.Location.X + 5, CSharpBtn.Location.Y);
        }

        private void CSharpBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = startLocation;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Position : {e.X} : {e.Y}";
            Point mouse = e.Location;
            if(mouse.X >= testBtn.Left - 20 && mouse.X <= testBtn.Left + testBtn.Width + 20)
            {
                if(mouse.X >= testBtn.Left)
                    testBtn.Left = testBtn.Left - 5;
                else
                    testBtn.Left = testBtn.Left + 5;
            }
        }
    }

   
}
