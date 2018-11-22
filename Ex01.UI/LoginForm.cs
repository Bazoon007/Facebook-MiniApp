using System;
using System.Windows.Forms;
using Ex01.Services;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.UI
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult loginResult = Login.LoginWithFacebook();
            if (loginResult != null)
            {
                new MainForm(loginResult).Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong - please try again");
            }
        }
    }
}
