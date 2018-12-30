using FacebookWrapper.ObjectModel;

namespace Ex02.Services
{
    public class UserFacade
    {
        private readonly FacebookObjectCollection<Post> r_Posts;
        private readonly FacebookObjectCollection<Album> r_Albums;
        private readonly string r_Id;
        private readonly string r_FirstName;
        private readonly string r_LastName;
        private readonly string r_PictureNormalURL;
        private readonly string r_Birthday;
        private readonly string r_Gender;
        private readonly string r_Email;
        private readonly string r_Hometown;
        private readonly int r_FriendsCount;

        public UserFacade(User i_User)
        {
            r_Posts = i_User.WallPosts;
            r_Albums = i_User.Albums;
            r_Id = i_User.Id;
            r_FirstName = i_User.FirstName;
            r_LastName = i_User.LastName;
            r_PictureNormalURL = i_User.PictureNormalURL;
            r_Birthday = i_User.Birthday;
            r_Gender = i_User.Gender == null ? string.Empty : i_User.Gender.ToString();
            r_Email = i_User.Email;
            r_Hometown = i_User.Hometown == null ? string.Empty : i_User.Hometown.ToString();
            r_FriendsCount = i_User.Friends == null ? 0 : i_User.Friends.Count;
        }

        public FacebookObjectCollection<Post> WallPosts
        {
            get
            {
                return r_Posts;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return r_Albums;
            }
        }

        public string Id
        {
            get
            {
                return r_Id;
            }
        }

        public string FirstName
        {
            get
            {
                return r_FirstName;
            }
        }

        public string LastName
        {
            get
            {
                return r_LastName;
            }
        }

        public string PictureNormalURL
        {
            get
            {
                return r_PictureNormalURL;
            }
        }

        public string Birthday
        {
            get
            {
                return r_Birthday;
            }
        }

        public string Gender
        {
            get
            {
                return r_Gender;
            }
        }

        public string Email
        {
            get
            {
                return r_Email;
            }
        }

        public string Hometown
        {
            get
            {
                return r_Hometown;
            }
        }

        public int FriendsCount
        {
            get
            {
                return r_FriendsCount;
            }
        }
    }
}
