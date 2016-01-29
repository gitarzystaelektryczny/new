using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Piotrek.PersonManager
{
    public class FileStorage : IStorable
    {
        private List<Person> people = new List<Person>();
        string path = @"C:\temp\person.bin";

        public void AddPerson(Person person)
        {
            people.Add(person);
            BinaryStream<List<Person>>.BinarySerializer(path, people);
        }

        public List<Person> GetAllPersons()
        {
            people = BinaryStream<List<Person>>.Deserialize(path);
            return people;
        }
    }
}
