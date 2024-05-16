using System.Runtime.ConstrainedExecution;
using SystemDelivery;

namespace BookLibraryDecorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            BookBase book = new BookBase("titolo", "esempio", 10); //se bisogna inserire dta new datetime(anno-mese-giorno)
            BookDateDecorator bookdate=new BookDateDecorator(book, new DateTime(14/6/2024));
            BookEmailDecorator email=new BookEmailDecorator(book,"email di esempio per ritardo");

            Console.WriteLine("Do you want to borrow a book?");
            string borrow = Console.ReadLine();
            if (borrow == "yes")
            {

                Console.WriteLine("Wich book title?");

                string title = Console.ReadLine();
                if (book.Title == title)
                {

                    Console.WriteLine(book.BorrowBook());
                    Console.WriteLine("Quanti giorni?");
                    int numerogiorni = int.Parse(Console.ReadLine());
                    Console.WriteLine(bookdate.BorrowBookDate(numerogiorni));
                }

                if (DateTime.Now>bookdate._deadlineDate)
                {
                    Console.WriteLine(email.BorrowBookDateEMail (new DateTime(14 / 6 / 2024)));

                }












            }
        }

        }
    }

