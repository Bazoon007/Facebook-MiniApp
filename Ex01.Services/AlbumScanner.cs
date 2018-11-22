using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.Services
{
    public class AlbumScanner
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        public Album ScannedAlbum { get; set;}
        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return r_Albums;
            }
        }

        public AlbumScanner(User i_User)
        {
            r_Albums = i_User.Albums;
        }
    }
}
