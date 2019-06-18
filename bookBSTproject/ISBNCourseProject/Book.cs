using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBNCourseProject
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public int PubYear { get; set; }

        public Book()
        {
            Title = "No Such Book";
            Author = "";
            ISBN = 0;
            Rating = 0;
            PubYear = 0;
        }
    }
}
