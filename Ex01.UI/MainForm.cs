using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Ex01.Services;

namespace Ex01.UI
{
    public partial class MainForm : Form
    {
        private readonly AppSettings r_AppSettings;
        private User m_User;

        public MainForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_User = i_LoginResult.LoggedInUser;
            r_AppSettings  = AppSettings.LoadFromFile();
            initMainForm();
        }

        private void initMainForm()
        {
            labelWelcome.Text = string.Format("Welcome, {0} {1}!", m_User.FirstName, m_User.LastName);
            pictureBoxProfilePicture.LoadAsync(m_User.PictureNormalURL);
            buttonLogout.DialogResult = DialogResult.Cancel;
            setDetailsLabel(labelBirthday, m_User.Birthday);
            setDetailsLabel(labelGender, m_User.Gender);
            setDetailsLabel(labelEmail, m_User.Email);
            setDetailsLabel(labelHometown, m_User.Hometown);
            setDetailsLabel(labelNoOfFriends, m_User.Friends.Count);
            checkBoxRememberMe.Checked = r_AppSettings.RememberMe;
        }

        private void buttonAlbumScanner_Click(object sender, EventArgs e)
        {
            new AlbumScannerForm(m_User).Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            setAppSettingsRememberMe();
            FacebookService.Logout(null);
        }

        private void buttonBlastFromThePast_Click(object sender, EventArgs e)
        {
            new BlastFromThePastForm(m_User).Show();
        }

        private void setDetailsLabel(Label i_Label, object i_Value)
        {
            i_Label.Text = i_Value == null ? string.Empty : i_Value.ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            setAppSettingsRememberMe();
            r_AppSettings.SaveToFile();
            FacebookService.Logout(null);
            base.OnFormClosing(e);
        }

        private void setAppSettingsRememberMe()
        {
            r_AppSettings.RememberMe = checkBoxRememberMe.Checked;
        }
    }
}
