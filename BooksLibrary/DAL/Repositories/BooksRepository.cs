using System;
using System.Collections.ObjectModel;
using System.Linq;
using BooksLibrary.Domain.Interfaces.Repositories;
using BooksLibrary.Domain.Model;

namespace DAL.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly Collection<Book> _booksDataContext;
        private readonly object _syncObject = new object();

        public BooksRepository()
        {
            _booksDataContext = DataContext.CreateBooksDataContext();
        }

        public int Add(Book item)
        {
            lock (_syncObject)
            {
                var maxAuthorId = _booksDataContext.Max(author => author.Id);
                item.Id = maxAuthorId + 1;
                _booksDataContext.Add(item);
                return item.Id;
            }
        }

        public void Delete(int key)
        {
            var obj = _booksDataContext.FirstOrDefault(item => item.Id == key);
            if (obj == null)
            {
                throw new ArgumentException($"Delete failed: element with Id {key} not found.");
            }

            _booksDataContext.Remove(obj);
        }

        public Book Get(int key)
        {
            var obj = _booksDataContext.FirstOrDefault(item => item.Id == key);
            if (obj == null)
            {
                throw new ArgumentException($"Element with Id {key} not found.");
            }

            return obj;
        }
    }
}
