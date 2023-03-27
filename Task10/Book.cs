using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Book
    {
      

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int CopiesAvailable { get; set; }


        public Book(string iSBN, string title, string author, string genre, int copiesAvailable)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            Genre = genre;
            CopiesAvailable = copiesAvailable;
        }


    }
}
