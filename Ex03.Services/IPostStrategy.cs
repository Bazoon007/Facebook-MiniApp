using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03.Services
{
    public interface IPostStrategy
    {
        Post GetPost(IEnumerable<Post> i_Posts);
    }
}
