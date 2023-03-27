using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<Book> BorrowedBooks = new List<Book>();
        public decimal Fine { get; set; } = 0;
        
        public Book Book { get; set; }
        public Borrower(int id, string name, string contactInfo)
        {
            Id = id;
            Name = name;
            ContactInfo = contactInfo;
        }

        public int MaxBooksAllowed { get; set; } = 3;

        public void  BorrowBook(Book book)
        {
            if(BorrowedBooks.Count >= MaxBooksAllowed)
            {
                throw new InvalidOperationException("You can not borrow more than 3 books at a time");
            }

            if(Book.CopiesAvailable == 0)
            {
                throw new InvalidOperationException("The book is not available");
            }

        }
    }

    
    }

