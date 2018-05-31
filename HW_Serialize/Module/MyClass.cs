using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace HW_Serialize.Module
{
    [Serializable]

    public class MyClass
    {
        /*имя; фамилия; телефон; год рождения*/
        string path = @"MyFile.csv";
        public Person p = new Person();
        //List<Person> person;

        public void AddToFile()
        {
            FileInfo file = new FileInfo(path);

            using (StreamWriter sw = new StreamWriter(path))
            {
                //sw.WriteLine(p.Name);
                //sw.WriteLine(p.Family);
                //sw.WriteLine(p.Tel);
                //sw.WriteLine(p.Dfb);

                sw.Write("Ivan");
                sw.Write(" ");
                sw.Write("Ivanov");
                sw.Write(" ");
                sw.Write("8777777770");
                sw.Write(" ");
                sw.WriteLine("1999");

                Console.WriteLine("The file is created");
            }
        }

        public void ReadFileAndAddToList()
        {
            FileInfo file = new FileInfo(path);

            using (StreamReader sr = new StreamReader(path))
            {
                string temp = sr.ReadLine();
                var m = temp.Split(' ');
                p.Name = m[0];
                p.Family = m[1];
                p.Tel = m[2];
                p.Dfb = m[3];
                p.person.Add(p);
            }

        }

        public void Print()
        {
            foreach (Person item in p.person)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Family);
                Console.WriteLine(item.Tel);
                Console.WriteLine(item.Dfb);
            }
        }

        public void SoapSerialize()
        {
            SoapFormatter formater = new SoapFormatter();

            using (FileStream fs = new FileStream("Person.soap", FileMode.OpenOrCreate))
            {          
                formater.Serialize(fs, p);
                Console.WriteLine("Serial OK!");
            }
        }
    }
}
