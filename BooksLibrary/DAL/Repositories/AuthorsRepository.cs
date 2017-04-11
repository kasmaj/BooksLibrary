using System;
using System.Collections.ObjectModel;
using BooksLibrary.Domain.Interfaces.Repositories;
using BooksLibrary.Domain.Model;

namespace DAL.Repositories
{
    public class AuthorsRepository  : IAuthorsRepository
    {
        private Collection<Author> _authorsDataContext;

        public AuthorsRepository()
        {
            _authorsDataContext = DataContext.CreateAuthorsDataContext();
        }

        public int Add(Author item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public Author Get(int key)
        {
            throw new NotImplementedException();
        }
    }
}
