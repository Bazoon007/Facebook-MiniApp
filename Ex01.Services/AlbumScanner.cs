using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace Ex01.Services
{
    public class AlbumScanner
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        private readonly string r_UserId;

        public Album ScannedAlbum { get; set; }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return r_Albums;
            }
        }

        public AlbumScanner(UserFacade i_User)
        {
            r_Albums = i_User.Albums;
            r_UserId = i_User.Id;
        }

        public IList<Image> FetchPhotosByFilter(bool i_Filter, IList<string> i_TaggedPersonList)
        {
            IList<Image> imageList = new List<Image>();
            if (ScannedAlbum.Photos != null)
            {
                foreach (Photo photo in ScannedAlbum.Photos)
                {
                    if (!i_Filter || checkPhotoForTagFilter(photo, i_TaggedPersonList))
                    {
                        imageList.Add(photo.ImageNormal);
                    }
                }
            }

            return imageList;
        }

        public IList<string> FetchTaggedPersonList(bool i_Filter)
        {
            IList<string> stringList = new List<string>();
            foreach (Photo photo in ScannedAlbum.Photos)
            {
                if (photo.Tags != null && !i_Filter)
                {
                    foreach (PhotoTag tag in photo.Tags)
                    {
                        stringList.Add(tag.User.Name);
                    }
                }
            }

            return stringList;
        }

        private bool checkPhotoForTagFilter(Photo i_Photo, IList<string> i_ChosenTaggedPersonList)
        {
            const bool v_TagFound = true;
            bool tagFound = !v_TagFound;
            if (i_Photo.Tags != null)
            {
                foreach (PhotoTag tag in i_Photo.Tags)
                {
                    foreach (string taggedPersonName in i_ChosenTaggedPersonList)
                    {
                        if (taggedPersonName.Equals(tag.User.Name))
                        {
                            tagFound = v_TagFound;
                            break;
                        }
                    }

                    if (tagFound || i_ChosenTaggedPersonList.Count == 0)
                    {
                        tagFound = v_TagFound;
                        break;
                    }
                }
            }
            else if (i_ChosenTaggedPersonList.Count == 0)
            {
                tagFound = v_TagFound;
            }

            return tagFound;
        }

        public bool LikeAllPhotos()
        {
            const bool v_LikeSuccessful = true;
            foreach (Photo photo in ScannedAlbum.Photos)
            {
                PhotoProxy photoProxy = new PhotoProxy() { Photo = photo };
                if (!photoProxy.photoLikedByMe(r_UserId))
                {
                    photo.Like();
                }
            }

            return v_LikeSuccessful;
        }
    }   
}
