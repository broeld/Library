using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Library : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
