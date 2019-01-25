using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.Services
{
    public interface IPostStrategy
    {
        Post GetPost(int i_Year);
    }
}
