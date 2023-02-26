using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_AdittionalForms
{
    public partial class SecondForm : Form
    {  

        private string userName;

        public string UserName
        {
            get { return userName; }
            set 
            { 
                userName = value;
                userNameLb.Text = $"Hello dear, {userName}";
            }
        }

        public SecondForm()
        {
            InitializeComponent();
        }
        public SecondForm(string name)
        {
            InitializeComponent();
            this.UserName = name;
            userNameLb.Text = $"Hello dear, {UserName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello dear, {UserName}");
        }
       
        public void Show(string name) 
        {
            UserName = name;
            this.Show();    
        }
    }
}
