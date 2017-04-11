using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksLibrary.Domain.Model;

namespace BooksLibrary.Domain.Interfaces.Repositories
{
    public interface IAuthorsRepository : IRepository<Author, int>
    {
    }
}
