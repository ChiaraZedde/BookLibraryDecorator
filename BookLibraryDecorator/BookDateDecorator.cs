using BookLibraryDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery
{
    public  class BookDateDecorator : Book
    {
        public DateTime _deadlineDate;
        private Book _book;
    

        public BookDateDecorator(Book book, DateTime deadlineDate) : base(book.Title, book.Author, book.NumberOfCopy)
        {
            _book = book;
            _deadlineDate = deadlineDate;
        }

        public  DateTime BorrowBookDate( int numerogiorni)
        {
           _deadlineDate=_deadlineDate.AddDays(numerogiorni);
            return _deadlineDate;

            
        }

    }
}
