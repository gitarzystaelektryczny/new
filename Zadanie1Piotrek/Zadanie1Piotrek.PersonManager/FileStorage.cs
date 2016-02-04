using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie1Piotrek.PersonManager
{
    public class FileStorage : IStorable
    {        
        private string path = "person.xml";
                
        public void AddPerson(Person person)
        {
            if (File.Exists(path))
            {
                List<Person> people = GetAllPersons();
                people.Add(person);
                XMLSerializer.Serialization(people, path);                
            }
            else
            {
                List<Person> people = new List<Person>();
                people.Add(person);
                XMLSerializer.Serialization(people, path);
            }
        }

        public List<Person> GetAllPersons()
        {
            if (File.Exists(path))
            {                
                return XMLSerializer.Deserialization(path);
            }
            else
            {
                return new List<Person>();
            }
        }
    }
}
