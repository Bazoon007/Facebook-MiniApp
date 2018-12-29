using System.Collections.Generic;

namespace Ex02.Services
{
    public class CompositePhotoProxy : IPhotoComponent
    {
        private readonly IList<IPhotoComponent> r_Components = new List<IPhotoComponent>();

        public void Add(IPhotoComponent i_PhotoComponent)
        {
            if (!r_Components.Contains(i_PhotoComponent))
            {           
                r_Components.Add(i_PhotoComponent);
            }
            else
            {
                Remove(i_PhotoComponent);
            }
        }

        public IList<IPhotoComponent> GetChildren()
        {
            return r_Components;
        }

        public bool Like(string i_UserId)
        {
            const bool v_LikeSuccessful = true;
            bool likeSuccessful = !v_LikeSuccessful;
            foreach (IPhotoComponent component in r_Components)
            {
                if (component.Like(i_UserId))
                {
                    likeSuccessful = v_LikeSuccessful;
                }
            }

            return likeSuccessful;
        }

       public void Remove(IPhotoComponent i_PhotoComponent)
        {
            r_Components.Remove(i_PhotoComponent);
        }
    }
}
