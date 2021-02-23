using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ReaderService : IReaderService
    {
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
