using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class StatisticService : IStatisticService
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        public StatisticService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }
        public IEnumerable<BookModel> GetMostPopularBooks(int bookCount)
        {
            throw new NotImplementedException();
        }
    }
}
