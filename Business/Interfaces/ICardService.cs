using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICardService : ICrud<CardModel>
    {
        IEnumerable<BookModel> GetBooksByCardId(int cardId);

        Task TakeBookAsync(int cardId, int bookId);

        Task HandOverBookAsync(int cardId, int bookId);
    }
}
