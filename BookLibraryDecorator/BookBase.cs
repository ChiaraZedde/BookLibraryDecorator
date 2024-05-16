using BookLibraryDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDelivery

{       //IceCreamBase
        public class BookBase : Book
    {

        public BookBase(string title, string author, int numberOfCopy) : base(title, author, numberOfCopy)
        {
        }

        public  string BorrowBook()
        {
            if (NumberOfCopy > 0)
            {
                NumberOfCopy--;
               return $"Hai preso in prestito '{Title}' di {Author}. Copie disponibili rimaste: {NumberOfCopy}";
            }
            else
            {
                return $"Non hai preso in prestito";
            }
            
        }

 



        }
    }

