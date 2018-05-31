using HW_Serialize.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Serialize
{
    class Program
    {
        /*1.	Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год.
              Создать коллекцию элементов Book и заполнить тестовыми данными.
              С помощью класса BinaryFormatter сохранить состояние приложения в двоичный файл.
          2.	На основании задания 1 восстановить состояние приложения из двоичного файла.         
          4.	Из csv файла (имя; фамилия; телефон; год рождения) прочитать записи в коллекцию.
              Каждая запись коллекции должна иметь тип Person. Сериализовать коллекцию с помощью класса SoapFormatter и сохранить в файл.*/

        static void Main(string[] args)
        {
            Servicebook sb = new Servicebook();

            sb.GenerBooks();
            sb.SerializeMetod();
            sb.DeserializeMetod();

            Console.WriteLine("==============================================");
            Console.WriteLine();

            MyClass mc = new MyClass();

            mc.AddToFile();
            mc.ReadFileAndAddToList();

            mc.SoapSerialize();

            mc.Print();


        }
    }
}
