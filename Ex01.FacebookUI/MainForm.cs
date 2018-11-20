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

namespace Ex01.FacebookUI
{
    public partial class MainForm : Form
    {
        //private bool m_OptionWindowsIsOpen = false;
        //private AppSettings m_appSettings;
        private User m_User  = null;
        private string m_AccessToken = null;

        private const string k_AppId = "293329964644734";
        private readonly string[] r_Permissions = { 
                "public_profile",
                "user_birthday",
                "user_friends",
                "user_events",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_tagged_places",
                "user_videos",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",};
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult loginLocalResult = FacebookService.Login(k_AppId, r_Permissions);
            m_User = loginLocalResult.LoggedInUser;
            m_AccessToken = loginLocalResult.AccessToken;
            if (m_User == null || string.IsNullOrEmpty(m_AccessToken))
            {
                MessageBox.Show("Something went wrong - Please try again");
            }
            else
            {
                MessageBox.Show(m_User.Birthday.ToString());
                //setMenuForUser();
                //enabeldAllPanels();
            }
        }
    }
}

