using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIteraror(books.OrderBy(b => b, new BookComparator()).ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIteraror : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currIndex;

            public LibraryIteraror(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }


            public void Dispose() { }
            public bool MoveNext() => ++this.currIndex < this.books.Count;
            public void Reset() => this.currIndex = -1;
            public Book Current => this.books[this.currIndex];
            object IEnumerator.Current => this.Current;
        }
    }
}
