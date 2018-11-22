using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.Services
{
    public static class Login
    {   
        //private AppSettings m_appSettings;
        private const string k_AppId = "293329964644734";
        private readonly static string[] sr_Permissions = {
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

        public static LoginResult LoginWithFacebook()
        {
            LoginResult loginResult = FacebookService.Login(k_AppId, sr_Permissions);
            if (loginResult.LoggedInUser == null || string.IsNullOrEmpty(loginResult.AccessToken))
            {
                loginResult = null;
            }
            return loginResult;
        }
    }
}
