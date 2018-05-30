using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Serialize
{
    [Serializable]

    public class Book
    {
        //Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год.

        public string BookName { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }

        public Book(string BookName, double Price, string Author, string Year)
        {
            this.BookName = BookName;
            this.Price = Price;
            this.Author = Author;
            this.Year = Year;
        }
    }
}
