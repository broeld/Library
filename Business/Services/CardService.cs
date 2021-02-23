using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CardService : ICardService
    {
        public Task AddAsync(CardModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int modelId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CardModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> GetBooksByCardId(int cardId)
        {
            throw new NotImplementedException();
        }

        public Task<CardModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task HandOverBookAsync(int cardId, int bookId)
        {
            throw new NotImplementedException();
        }

        public Task TakeBookAsync(int cardId, int bookId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CardModel model)
        {
            throw new NotImplementedException();
        }
    }
}
