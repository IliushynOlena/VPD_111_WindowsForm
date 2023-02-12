using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ProgressBar
{
    public partial class Form1 : Form
    {
        Timer timer = null;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            else
                progressBar1.Value++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;

            decimal max = (numericUpDown1.Value > progressBar1.Maximum ?
                progressBar1.Maximum : numericUpDown1.Value);

            while (progressBar1.Value < max)
            {
                progressBar1.Value++;
                progressBar1.Update();
                System.Threading.Thread.Sleep(50);
            }
            progressBar1.Style = ProgressBarStyle.Marquee;

        }
        private void UpdateColor()
        {
            Color c = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = c;
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
     
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = trackBar4.Value/100.0;
        }
    }
}
