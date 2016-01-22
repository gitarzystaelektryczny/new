using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    internal class MemoryStorage : IStorable
    {
        private List<Person> persons = new List<Person>();
        private Person person = new Person();                          

        public void AddPerson(Person person)
        {
                       
            persons.Add(person);

        }

       
        public List<Person> GetAllPersons()
        {
            return persons;
        }
    }
}
