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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open Form
            //
            //SecondForm secondForm = new SecondForm();
            ////secondForm.Show();//in nomodal mode
            //secondForm.ShowDialog();//in modal mode

            //1 using constructor
            string name = nameTb.Text;
            //SecondForm form = new SecondForm(name);
            //form.Show();
            //2 - using property 
            //SecondForm form = new SecondForm();
            //form.UserName = name;
            //form.Show();

            //3 using custom Show/ShowDialog method
            SecondForm form = new SecondForm();
            form.Show(name);

        }

        private void openLoginBtn_Click(object sender, EventArgs e)
        {
            ////Pull with child form
            //LoginInfo info;
            //LoginForm form = new LoginForm();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    info = form.LoginInfo;

            //    loginLb.Text = info.Login;
            //    passwordLb.Text = info.Password;
            //}
           

            LoginInfo loginInfo = new LoginInfo();
            LoginForm form = new LoginForm(loginInfo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                loginLb.Text = loginInfo.Login;
                passwordLb.Text = loginInfo.Password;
            }

        }


    }
}
