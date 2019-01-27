using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03.Services
{
    public class AlbumScanner : FacebookFeature
    {
        private readonly FacebookObjectCollection<Album> r_Albums;

        public Album ScannedAlbum { get; set; }
        private readonly IList<IPhotoComponent> r_SelectedPhotosList = new List<IPhotoComponent>();
        public bool LikedAllSelectedPhotosSuccess { get; set; }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return r_Albums;
            }
        }

        public IList<IPhotoComponent> SelectedPhotosList
        {
            get
            {
                return r_SelectedPhotosList;
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

        private void likeSelectedPhotos()
        {
            const bool v_LikeSuccessful = true;
            const bool v_SelfLikedPhoto = true;
            LikedAllSelectedPhotosSuccess = !v_LikeSuccessful;
            bool selfLikedPhoto = !v_SelfLikedPhoto;
            foreach (IPhotoComponent photo in SelectedPhotosList)
            {
                try
                {
                    if (!photo.Like(UserId))
                    {
                        selfLikedPhoto = v_SelfLikedPhoto;
                        break;
                    }
                    LikedAllSelectedPhotosSuccess = !selfLikedPhoto;
                }
                catch
                {
                    LikedAllSelectedPhotosSuccess = !v_LikeSuccessful;
                }
            }
        }

        public class LikeSelectedPhotosCommand : ICommand
        {
            public AlbumScanner Client { get; set; }

            public void Execute()
            {
                Client.likeSelectedPhotos();
            }
        }
    }   
}
