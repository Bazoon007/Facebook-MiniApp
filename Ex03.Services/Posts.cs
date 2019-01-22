using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex03.Services
{
    /// the ConcreteAggregate
    public class Posts : IAggregate
    {
        private readonly IList<Post> r_Posts;

        public Posts(int i_Year, FacebookObjectCollection<Post> i_Posts)
        {
            r_Posts = new List<Post>();
            foreach (Post post in i_Posts)
            {
                if (post.CreatedTime.Value.Year == i_Year)
                {
                    r_Posts.Add(post);
                }
            }

            r_Posts.Shuffle();
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
                m_Count = m_Agregate.r_Posts.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = -1;
            }

            public bool MoveNext()
            {
                if (m_Count != m_Agregate.r_Posts.Count)
                {
                    throw new Exception("Collection can not be changed during iteration!");
                }
                if (m_CurrentIdx >= m_Count)
                {
                    Reset();
                }

                return ++m_CurrentIdx < m_Agregate.r_Posts.Count;
            }

            public object Current
            {
                get { return m_Agregate.r_Posts[m_CurrentIdx].Name; }
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


    //Thread Safe Shuffle.
    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
