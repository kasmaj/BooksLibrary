using System;
using System.Collections.ObjectModel;
using BooksLibrary.Domain.Interfaces.Repositories;
using BooksLibrary.Domain.Model;

namespace DAL.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private Collection<Book> _booksDataContext;

        public BooksRepository()
        {
            _booksDataContext = DataContext.CreateBooksDataContext();
        }

        public int Add(Book item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public Book Get(int key)
        {
            throw new NotImplementedException();
        }
    }
}
