using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IReaderService : ICrud<ReaderModel>
    {
        IEnumerable<ReaderModel> GetReadersThatDontReturnBooks();
    }
}
