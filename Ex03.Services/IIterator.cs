using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03.Services
{
        /// The Aggregte interface
        public interface IAggregate
        {
            IIterator CreatePostsIterator();
        }

        /// The Iterator interface
        public interface IIterator
        {
            bool MoveNext();
            object Current { get; } /// polymorphic item reference
            void Reset();
        }
}
