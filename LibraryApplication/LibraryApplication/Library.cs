using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Library
    {
        public List<string> Books = new List<string>();
        public List<string> Popular = new List<string>();

        public Library() { }

        public Library(List<string> books, List<string> popular)
        {
            Books = books;
            Popular = popular;
        }
    }
}
