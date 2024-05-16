using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryDecorator
{
    public abstract class Book
    {
        public string Title;
        //{ get { return Title; }  set { Title = "example"; } }

        public string Author { get; set; }
        public int NumberOfCopy { get; set; }
        // public string DeadlineDate { get; set; }


        public Book(string title, string author, int numberOfCopy)
        {
            Title = title;
            Author = author;
            NumberOfCopy = numberOfCopy;

        }


    }
}
