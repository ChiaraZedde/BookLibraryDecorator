using BookLibraryDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery
{
    public abstract class BookDateEmailDecorator : Book
    {
        protected private DateTime _deadlineDate;
        protected private Book _book;

        public BookDateEmailDecorator(Book book, DateTime deadlineDate): base(book.Title, book.Author, book.NumberOfCopy)
        {
            _book = book;
            _deadlineDate = deadlineDate;
          

        }

        
       
    }
}