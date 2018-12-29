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
            userFacadeBindingSource.DataSource = r_User;
            pictureBoxProfilePicture.LoadAsync(r_User.PictureNormalURL);
            buttonLogout.DialogResult = DialogResult.Cancel;
            checkBoxRememberMe.Checked = r_AppSettings.RememberMe;
        }

        private void buttonAlbumScanner_Click(object sender, EventArgs e)
        {
            FeatureFormFactory.CreateForm(r_User, (sender as Button).Name).Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            setAppSettingsRememberMe();
            FacebookService.Logout(null);
        }

        private void buttonBlastFromThePast_Click(object sender, EventArgs e)
        {
            FeatureFormFactory.CreateForm(r_User, (sender as Button).Name).Show();
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
