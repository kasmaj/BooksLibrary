using BooksLibrary.Domain.Model;
using System.Collections.ObjectModel;

namespace DAL
{
    public class DataContext
    {
        public static Collection<Book> CreateBooksDataContext()
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

        public static Collection<Author> CreateAuthorsDataContext()
        {
            return new Collection<Author>
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
