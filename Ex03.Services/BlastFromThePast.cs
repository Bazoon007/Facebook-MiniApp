using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace Ex03.Services
{
    public class BlastFromThePast : FacebookFeature
    {
        private static readonly Random sr_RandomPostPicker = new Random();
        private readonly FacebookObjectCollection<Post> r_Posts;
        public Post PostResult { get; private set; }
        public IPostStrategy PostStrategy { get; set; }

        public BlastFromThePast(UserFacade i_User) : base(i_User)
        {
            r_Posts = i_User.WallPosts;
        }

        public ISet<int> CreateYearSet()
        {
            ISet<int> yearSet = new HashSet<int>();
            foreach (Post post in r_Posts)
            {
                yearSet.Add(post.CreatedTime.Value.Year);
            }

            return yearSet;
        }

        private IList<Post> createPostYearList(int i_Year)
        {
            IList<Post> postList = new List<Post>();
            foreach (Post post in r_Posts)
            {
                if (post.CreatedTime.Value.Year == i_Year)
                {
                    postList.Add(post);
                }
            }

            return postList;
        }

        private Post randomPost(int i_Year)
        {
            IList<Post> postList = createPostYearList(i_Year);
            int random = sr_RandomPostPicker.Next(postList.Count);

            return postList.ElementAt(random);
        }

        private Post mostLikedPost(int i_Year)
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

        public void ExecuteBlast(int i_Year, string i_BlastType)
        {
            IPostStrategy postStrategy = null;
            if (i_BlastType == "Random")
            {
                postStrategy = new RandomPostStrategy();
            }
            else if (i_BlastType == "Most Liked")
            {
                postStrategy = new MostLikedPostStrategy();
            }

            if (!string.IsNullOrEmpty(i_BlastType) && i_Year > 0)
            {
                PostResult = PostStrategy.GetPost(i_Year);
            }
        }

        public class ExecuteBlastCommand : ICommand
        {
            public BlastFromThePast Client { get; set; }
            public int Year { get; set; }
            public string BlastType { get; set; }

            public void Execute()
            {
                new Thread(() => Client.ExecuteBlast(Year, BlastType)).Start();
            }
        }

        private class RandomPostStrategy : IPostStrategy
        {
            public Post GetPost(int i_Year)
            {
                IList<Post> postList = createPostYearList(i_Year);
                int random = sr_RandomPostPicker.Next(postList.Count);

                return postList.ElementAt(random);
            }
        }

        private class MostLikedPostStrategy : IPostStrategy
        {
            public Post GetPost(int i_Year)
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
}
