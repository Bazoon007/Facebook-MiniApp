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
        private readonly UserFacade r_User;

        public MainForm(UserFacade i_User)
        {
            InitializeComponent();
            r_User = i_User;
            r_AppSettings  = AppSettings.LoadFromFile();
            initMainForm();
        }

        private void initMainForm()
        {
            /*
            labelWelcome.Text = string.Format("Welcome, {0} {1}!", r_User.FirstName, r_User.LastName);
            pictureBoxProfilePicture.LoadAsync(r_User.PictureNormalURL);
            buttonLogout.DialogResult = DialogResult.Cancel;
            setDetailsLabel(labelBirthday, r_User.Birthday);
            setDetailsLabel(labelGender, r_User.Gender);
            setDetailsLabel(labelEmail, r_User.Email);
            setDetailsLabel(labelHometown, r_User.Hometown);
            setDetailsLabel(labelNoOfFriends, r_User.Friends.Count);
            */
            checkBoxRememberMe.Checked = r_AppSettings.RememberMe;
        }

        private void buttonAlbumScanner_Click(object sender, EventArgs e)
        {
            new AlbumScannerForm(r_User).Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            setAppSettingsRememberMe();
            FacebookService.Logout(null);
        }

        private void buttonBlastFromThePast_Click(object sender, EventArgs e)
        {
            new BlastFromThePastForm(r_User).Show();
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
