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
        private List<Person> people = new List<Person>();
        private string path = "person.xml";
        string folder = Directory.GetCurrentDirectory();


        public void AddPerson(Person person)
        {
            if (File.Exists(path))
            {
                GetAllPersons();
                people.Add(person);
                XMLSerializer.Serialization(people, (path));
            }
            else
            {
                people.Add(person);
                XMLSerializer.Serialization(people, (path));
            }
        }

        public List<Person> GetAllPersons()
        {
            people=(XMLSerializer.Deserialization(path));
            return people;
        }
    }
}
