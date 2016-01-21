using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Piotrek
{
    public class MemoryStorage : IStorable
    {
        private List<Person> people = new List<Person>();

        public void AddPerson(Person person)
        {         
            people.Add(person);            
        }

        public List<Person> GetAllPersons()
        {          
            return people;
        }        
    }
}