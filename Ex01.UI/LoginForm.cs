﻿using System;
using System.Windows.Forms;
using Ex02.Services;
using FacebookWrapper;

namespace Ex02.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginWithFacebook();
        }

        private void loginWithFacebook()
        {
            try
            {
                LoginResult loginResult = Login.LoginWithFacebook();
                UserFacade user = new UserFacade(loginResult.LoggedInUser);
                DialogResult dialogResult = new MainForm(user).ShowDialog();
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
