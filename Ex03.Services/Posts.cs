using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.Services
{
    /// the ConcreteAggregate
    public class Posts : IAggregate
    {
        private readonly List<PostItem> m_Posts;

        public Posts(int i_Year, FacebookObjectCollection<Post> i_Posts)
        {
            IList<Post> m_Posts = new List<Post>();
            foreach (Post post in i_Posts)
            {
                if (post.CreatedTime.Value.Year == i_Year)
                {
                    m_Posts.Add(post);
                }
        }

    }

        public IIterator CreatePostsIterator()
        {
            return new PostsIterator(this);
        }

        /// The ConcreteIterator:
        /// This is a private nested class, which is tightly-coupled 
        /// with the aggregate, and is specific to its needs.
        private class PostsIterator : IIterator
        {
            private Posts m_Agregate;
            private int m_CurrentIdx = -1;
            private int m_Count = -1;

            public PostsIterator(Posts i_Collection)
            {
                m_Agregate = i_Collection;
                m_Count = m_Agregate.m_Posts.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = -1;
            }

            public bool MoveNext()
            {
                if (m_Count != m_Agregate.m_Posts.Count)
                {
                    throw new Exception("Collection can not be changed during iteration!");
                }
                if (m_CurrentIdx >= m_Count)
                {
                    throw new Exception("Already reached the end of the collection");
                }

                return ++m_CurrentIdx < m_Agregate.m_Posts.Count;
            }

            public object Current
            {
                get { return m_Agregate.m_Posts[m_CurrentIdx].Name; }
            }
        }
    }

    public class PostItem
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public string Prefix { get; set; }
        public float Area { get; set; }
    }
}
