using System.Collections.Generic;

namespace Ex03.Services
{
    public interface IPhotoComponent
    {
        void Add(IPhotoComponent i_PhotoComponent);

        void Remove(IPhotoComponent i_PhotoComponent);

        IList<IPhotoComponent> GetChildren();

        bool Like(string i_UserId);
    }
}
