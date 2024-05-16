using BookLibraryDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery
{
    public class BookEmailDecorator : Book
    {
        private string _email;
        private Book _book;

        public BookEmailDecorator(Book book, string email) : base(book.Title, book.Author, book.NumberOfCopy)
        {
            _book = book;
            _email = email;
        }


        public string BorrowBookDateEMail(DateTime dataScadenza)
        {

            if (DateTime.Now > dataScadenza)
            {
                //Console.WriteLine("Questa è una mail di avviso per il ritardo");
                return "Questa è una mail di avviso per il ritardo";

            }
            else
            {
                return "";
            }
        }
    }

}

