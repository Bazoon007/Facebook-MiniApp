using FacebookWrapper;

namespace Ex01.Services
{
    public static class Login
    {
        private const string k_AppId = "293329964644734";
        private static readonly string[] sr_Permissions =
        {
                "public_profile",
                "user_birthday",
                "user_friends",
                "user_events",
                "user_hometown",
                "email",
                "user_likes",
                "user_gender",
                "user_location",
                "user_photos",
                "user_posts",
                "user_tagged_places",
                "user_videos",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages"
        };

        private static AppSettings s_appSettings;

        public static LoginResult LoginWithFacebook()
        {
            LoginResult loginResult = null;
            s_appSettings = AppSettings.LoadFromFile();
            if (!string.IsNullOrEmpty(s_appSettings.LastAccessToken) && s_appSettings.RememberMe)
            {
                loginResult = FacebookService.Connect(s_appSettings.LastAccessToken);
            }
            else
            {
                loginResult = FacebookService.Login(k_AppId, sr_Permissions);
                if (loginResult.LoggedInUser == null || string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    loginResult = null;
                }
            }

            setAppSettingsLastAccessToken(loginResult);
            s_appSettings.SaveToFile();
            return loginResult;
        }

        private static void setAppSettingsLastAccessToken(LoginResult i_LoginResult)
        {
            const bool v_RememberMe = true;
            s_appSettings.LastAccessToken = i_LoginResult.AccessToken;
            s_appSettings.RememberMe = v_RememberMe;
        }
    }
}
