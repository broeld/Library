using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class StatisticService : IStatisticService
    {
        public IEnumerable<BookModel> GetMostPopularBooks(int bookCount)
        {
            throw new NotImplementedException();
        }
    }
}
