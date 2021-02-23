using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public bool IsBorrwed { get; set; }
        public ICollection<History> Cards { get; set; } = new List<History>();
        public int LibraryId { get; set; }
        public Library Library { get; set; }

    }
}
