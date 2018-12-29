using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.Services
{
    public interface IPhotoComponent
    {
        void Add(IPhotoComponent i_PhotoComponent);

        void Remove(IPhotoComponent i_PhotoComponent);

        IList<IPhotoComponent> GetChildren();

        bool Like(string i_UserId);
    }
}
