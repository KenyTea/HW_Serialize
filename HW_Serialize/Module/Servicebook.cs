using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HW_Serialize.Module
{
    public enum Authors { Esenin = 1, Pusgkin, Strugatskie, Dragunkin }
    public enum Bookss { Skazki = 1, Stihi, Rasskazy }

    public class Servicebook
    {

        private Random r = new Random();
        public string path = @"book.dat";
        List<Book> book = new List<Book>();

        public void GenerBooks()
        {

            for (int i = 0; i < 4; i++)
            {
                string Author = ((Authors)r.Next(1, 4)).ToString();
                string BookName = ((Bookss)r.Next(1, 3)).ToString();
                double Price = (double)r.Next(1000, 3000);
                string Year = (r.Next(1756, 1999)).ToString();
                Book b = new Book(BookName, Price, Author, Year);
                book.Add(b);
            }
        }

        public void SerializeMetod()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, book);
                Console.WriteLine("Serialized!");
            }
        }

        public void DeserializeMetod() // 2.	На основании задания 1 восстановить состояние приложения из двоичного файла.
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var bookList = (List<Book>)formatter.Deserialize(fs);
                foreach (Book item in book)
                {
                    Console.WriteLine("Deserialized!");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Authir:  " + item.Author);
                    Console.WriteLine("book name:  " + item.BookName);
                    Console.WriteLine("Year:  " + item.Year);
                    Console.WriteLine("Price:  " + item.Price);
                }
            }
        }





    }
}

