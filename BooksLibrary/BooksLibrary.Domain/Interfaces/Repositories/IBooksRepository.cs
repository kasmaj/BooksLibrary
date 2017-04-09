using BooksLibrary.Domain.Model;

namespace BooksLibrary.Domain.Interfaces.Repositories
{
    public interface IBooksRepository : IRepository<Book, int>
    {
    }
}
