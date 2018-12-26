using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Ex01.Services
{
    public class UserFacade
    {
        private AppSettings AppSetting { get; set; }
        private readonly FacebookObjectCollection<Post> r_Posts;
        private readonly FacebookObjectCollection<Album> r_Albums;
        private readonly string r_Id;
        /*
        FirstName
        LastName
        PictureNormalURL
        Birthday
        Gender
        Email
        Hometown
        Friends
        Id
        */

        public UserFacade(User i_User)
        {
            r_Posts = i_User.WallPosts;
            r_Albums = i_User.Albums;
            r_Id = i_User.Id;
        }

        public FacebookObjectCollection<Post> Posts
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
    }
}
