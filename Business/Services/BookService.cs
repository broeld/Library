using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BookService : IBookService
    {
        public Task AddAsync(BookModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int modelId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> GetByFilter(FilterSearchModel filterSearch)
        {
            throw new NotImplementedException();
        }

        public Task<BookModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(BookModel model)
        {
            throw new NotImplementedException();
        }
    }
}
