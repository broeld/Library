using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        public BookService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

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
