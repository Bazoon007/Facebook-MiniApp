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
            try
            {
                LoginResult loginResult = Login.LoginWithFacebook();
                DialogResult dialogResult = new MainForm(loginResult).ShowDialog();
                Hide();
                if (dialogResult == DialogResult.Cancel)
                {
                    Show();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong - please try again");
            }
        }
    }
}
