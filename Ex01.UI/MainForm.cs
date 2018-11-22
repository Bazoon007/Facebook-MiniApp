using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.UI
{
    public partial class MainForm : Form
    {
        private User m_User;
        public MainForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_User = i_LoginResult.LoggedInUser;
            initMainForm();
        }

        private void initMainForm()
        {
            labelWelcome.Text = string.Format("Welcome, {0} {1}!", m_User.FirstName, m_User.LastName);
            pictureBoxProfilePicture.LoadAsync(m_User.PictureNormalURL);
            buttonLogout.DialogResult = DialogResult.Cancel;
        }

        private void buttonAlbumScanner_Click(object sender, EventArgs e)
        {
            new AlbumScannerForm(m_User).Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(null);
        }

        private void buttonBlastFromThePast_Click(object sender, EventArgs e)
        {
            new BlastFromThePastForm(m_User).Show();
        }
    }
}
