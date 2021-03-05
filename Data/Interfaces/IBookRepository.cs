using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IQueryable<Book> FindAllWithDetails();

        Task<Book> GetByIdWithDetailsAsync(int id);
    }
}
