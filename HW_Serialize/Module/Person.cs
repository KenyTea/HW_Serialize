using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Serialize.Module
{
    [Serializable]

   public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Tel { get; set; }
        public string Dfb { get; set; }

        public List<Person> person = new List<Person>();

        //public Person()
        //{
        //    Name ="Ivan";
        //    Family = "Ivanov";
        //    Tel ="+7777777770";
        //    Dfb = "1999";
        //}

        //public void Print()
        //{
        //    foreach (var item in person)
        //    {
        //        Console.WriteLine(item.Name);
        //        Console.WriteLine(item.Family);
        //        Console.WriteLine(item.Tel);
        //        Console.WriteLine(item.Dfb);
        //    }
        //}
    }
}
