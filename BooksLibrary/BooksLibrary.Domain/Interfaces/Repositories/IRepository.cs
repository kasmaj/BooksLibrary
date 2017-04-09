namespace BooksLibrary.Domain.Interfaces.Repositories
{
    public interface IRepository<TItem , TId>
    {
        TId Add(TItem item);

        void Delete(TId key);

        TItem Get(TId key);
    }
}
