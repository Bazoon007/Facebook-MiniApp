using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace Ex01.Services
{
    public class AlbumScanner : FacebookFeature
    {
        private readonly FacebookObjectCollection<Album> r_Albums;

        public Album ScannedAlbum { get; set; }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return r_Albums;
            }
        }

        public AlbumScanner(UserFacade i_User) : base(i_User)
        {
            r_Albums = i_User.Albums;
        }

        public IList<PhotoProxy> FetchPhotosByFilter(bool i_Filter, IList<string> i_TaggedPersonList)
        {
            IList<PhotoProxy> photoList = new List<PhotoProxy>();
            if (ScannedAlbum.Photos != null)
            {
                foreach (Photo photo in ScannedAlbum.Photos)
                {
                    if (!i_Filter || checkPhotoForTagFilter(photo, i_TaggedPersonList))
                    {
                        photoList.Add(new PhotoProxy { Photo = photo });
                    }
                }
            }

            return photoList;
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

        public bool LikeAllPhotos(IList<IPhotoComponent> i_SelectedPhotosList)
        {
            const bool v_LikeSuccessful = true;
            bool likeSuccessful = v_LikeSuccessful;
            foreach (IPhotoComponent photo in i_SelectedPhotosList)
            {
                if (!photo.Like(UserId))
                {
                    likeSuccessful = !v_LikeSuccessful;
                }
            }

            return likeSuccessful;
        }
    }   
}
