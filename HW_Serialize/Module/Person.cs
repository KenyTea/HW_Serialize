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

        [NonSerialized]
        public List<Person> person = new List<Person>();


        public Person[] persons;
        public void FilPerson()
        {
            persons = person.ToArray();
        }
    }
}
