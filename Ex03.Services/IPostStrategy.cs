using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace Ex03.Services
{
    public interface IPostStrategy
    {
        Post GetPost(IEnumerable<Post> i_Posts);
    }
}
