using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.Services
{
    public class PhotoProxy : IPhotoComponent
    {
        public Photo Photo { get; set; }

        public void Add(IPhotoComponent i_PhotoComponent)
        {
            throw new NotImplementedException();
        }

        public IList<IPhotoComponent> GetChildren()
        {
            List<IPhotoComponent> list = new List<IPhotoComponent>
            {
                this
            };
            return list;
        }

        public bool Like(string i_UserId)
        {
            const bool v_LikeSuccessful = true;
            bool likeSuccessful = !v_LikeSuccessful;
            if (!photoLikedByMe(i_UserId))
            {
                Photo.Like();
                likeSuccessful = v_LikeSuccessful;
            }
            return likeSuccessful;
        }

        public void Remove(IPhotoComponent i_PhotoComponent)
        {
            throw new NotImplementedException();
        }

        private bool photoLikedByMe(string i_UserId)
        {
            const bool v_LikedByMe = true;
            bool likedByMe = !v_LikedByMe;
            foreach (User user in Photo.LikedBy)
            {
                if (user.Id.Equals(i_UserId))
                {
                    likedByMe = v_LikedByMe;
                    break;

                }
            }
            return likedByMe;
        }

    }
}



