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
    public class ReaderService : IReaderService
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        public ReaderService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }
        public Task AddAsync(ReaderModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int modelId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReaderModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ReaderModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReaderModel> GetReadersThatDontReturnBooks()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ReaderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
