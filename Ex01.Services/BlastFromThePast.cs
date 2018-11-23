using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace Ex01.Services
{
    public class BlastFromThePast
    {
        private static readonly Random sr_RandomPostPicker = new Random();
        private readonly FacebookObjectCollection<Post> r_Posts;
        private readonly string r_UserId;

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                return r_Posts;
            }
        }

        public string UserId
        {
            get
            {
                return r_UserId;
            }
        }

        public BlastFromThePast(User i_User)
        {
            r_UserId = i_User.Id;
            r_Posts = i_User.WallPosts;
        }

        public ISet<int> CreateYearSet()
        {
            ISet<int> yearSet = new HashSet<int>();
            foreach (Post post in Posts)
            {
                yearSet.Add(post.CreatedTime.Value.Year);
            }

            return yearSet;
        }

        private IList<Post> createPostYearList(int i_Year)
        {
            IList<Post> postList = new List<Post>();
            foreach (Post post in Posts)
            {
                if (post.CreatedTime.Value.Year == i_Year)
                {
                    postList.Add(post);
                }
            }

            return postList;
        }

        public Post RandomPost(int i_Year)
        {
            IList<Post> postList = createPostYearList(i_Year);
            int random = sr_RandomPostPicker.Next(postList.Count);

            return postList.ElementAt(random);
        }

        public Post MostLikedPost(int i_Year)
        {
            IList<Post> postList = createPostYearList(i_Year);
            Post mostLikedPost = null;
            int MaxLikes = -1;
            foreach (Post post in postList)
            {
                if (post.LikedBy.Count > MaxLikes)
                {                 
                    MaxLikes = post.LikedBy.Count;
                    mostLikedPost = post;
                }
            }

            return mostLikedPost != null ? mostLikedPost : null;
        }
    }
}
