using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class LibraryModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<int> BooksIds { get; set; }
    }
}
