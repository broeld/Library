using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Author { get; set; }

        public ICollection<int> CardsIds { get; set; } = new List<int>();
    }
}
