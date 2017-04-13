using System;
using System.Collections.ObjectModel;
using System.Linq;
using BooksLibrary.Domain.Interfaces.Repositories;
using BooksLibrary.Domain.Model;

namespace DAL.Repositories
{
    public class AuthorsRepository  : IAuthorsRepository
    {
        private readonly Collection<Author> _authorsDataContext;
        private readonly object _syncObject = new object();

        public AuthorsRepository()
        {
            _authorsDataContext = DataContext.CreateAuthorsDataContext();
        }

        public int Add(Author item)
        {
            lock (_syncObject)
            {
                var maxAuthorId = _authorsDataContext.Max(author => author.Id);
                item.Id = maxAuthorId + 1;
               _authorsDataContext.Add(item);
                return item.Id;
            }
        }

        public void Delete(int key)
        {
            var obj = _authorsDataContext.FirstOrDefault(item => item.Id == key);
            if (obj == null)
            {
                throw new ArgumentException($"Delete failed: element with Id {key} not found.");
            }
            
            _authorsDataContext.Remove(obj);
        }

        public Author Get(int key)
        {
            var obj = _authorsDataContext.FirstOrDefault(item => item.Id == key);
            if (obj == null)
            {
                throw new ArgumentException($"Element with Id {key} not found.");
            }

            return obj;
        }
    }
}
