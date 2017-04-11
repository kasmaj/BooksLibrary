using System;
using BooksLibrary.Domain.Interfaces.Repositories;
using BooksLibrary.Domain.Model;

namespace DAL.Repositories
{
    public class BooksRepository : IBooksRepository
    {
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
