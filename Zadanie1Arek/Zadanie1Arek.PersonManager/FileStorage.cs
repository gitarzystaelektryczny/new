using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie1Arek.PersonManager
{
    public class FileStorage : IStorable
    {        
        private string path = "person.xml";
                
        public void AddPerson(Person person)
        {
            List<Person> persons = GetAllPersons();
            if (File.Exists(path))
            {                
                persons.Add(person);
                XMLSerializer.Serialization(persons, path);
            }
            else
            {
                persons.Add(person);
                XMLSerializer.Serialization(persons, path);
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
