using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class ReaderProfile
    {
        public int ReaderId { get; set; }

        public Reader Reader { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
