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
    public partial class LoginForm : Form
    {
        public LoginInfo LoginInfo { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            LoginInfo = new LoginInfo();    
        }
        public LoginForm(LoginInfo info)
        {
            InitializeComponent();
            LoginInfo = info;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTb.Text) || string.IsNullOrWhiteSpace(passwordTb.Text))
            {
                MessageBox.Show("Enter login and password!!");
                return;
            }
            //1
            //LoginInfo = new LoginInfo()
            //{
            //    Login = loginTb.Text,
            //    Password = passwordTb.Text
            //};
            //2
            LoginInfo.Login = loginTb.Text;
            LoginInfo.Password = passwordTb.Text;  
            this.DialogResult = DialogResult.OK;    
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();   
        }
    }
}
