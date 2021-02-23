using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IBookService : ICrud<BookModel>
    {
        IEnumerable<BookModel> GetByFilter(FilterSearchModel filterSearch);
    }
}
