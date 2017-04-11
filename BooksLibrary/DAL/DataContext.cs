using BooksLibrary.Domain.Model;
using System.Collections.ObjectModel;

namespace DAL
{
    public class DataContext
    {
        private Collection<Author> _authors;
        private Collection<Book> _books;

        public DataContext()
        {
            _authors = InitializeAuthorsDataContext();
            _books = InitializeBooksDataContext();
        }

        private Collection<Book> InitializeBooksDataContext()
        {
            return new Collection<Book>
            {
                new Book {Id = 1, AuthorId = 1, Title = "Diuna", Language = "PL", YearOfPublishing = 1975},
                new Book {},
                new Book {},
                new Book {},
                new Book {},
                new Book {}
            };
        }

        private Collection<Author> InitializeAuthorsDataContext()
        {
            return _authors = new Collection<Author>
            {
                new Author {Id = 1, FirstName = "Frank", LastName = "Herbert"},
                new Author{},
                new Author{},
                new Author{},
                new Author{}
            };
        }
    }
}
