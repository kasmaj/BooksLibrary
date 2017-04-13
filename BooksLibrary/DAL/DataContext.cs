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
                new Book {Id = 2, AuthorId = 2, Title = "Ala ma kota", Language = "PL", YearOfPublishing = 2001},
                new Book {Id = 3, AuthorId = 2, Title = "Po prostu książka", Language = "PL", YearOfPublishing = 2017},
                new Book {Id = 4, AuthorId = 3, Title = "Przewodnik po Tatrach", Language = "PL", YearOfPublishing = 2004},
                new Book {Id = 5, AuthorId = 4, Title = "Gotowanie dla opornich", Language = "PL", YearOfPublishing = 1997},
                new Book {Id = 6, AuthorId = 4, Title = "Programowanie dla geniuszy", Language = "PL", YearOfPublishing = 2015}
            };
        }

        public static Collection<Author> CreateAuthorsDataContext()
        {
            return new Collection<Author>
            {
                new Author {Id = 1, FirstName = "Frank", LastName = "Herbert"},
                new Author {Id = 2, FirstName = "Jan", LastName = "Kowalski"},
                new Author {Id = 3, FirstName = "Maria", LastName = "Nowak"},
                new Author {Id = 4, FirstName = "Witold", LastName = "Mariański"},
            };
        }
    }
}
