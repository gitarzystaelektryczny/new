using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Zadanie1Arek.PersonManager
{
    public class FileStorage : IStorable
    {
        private List<Person> persons = new List<Person>();
        string path = @"C:\Temp\person.bin";  //TODO: create directory

        public void AddPerson(Person person)
        {
            persons.Add(person);
            Serializators<List<Person>>.BinarySerializer(path, persons);
        }

        public List<Person> GetAllPersons()
        {
            persons = Serializators<List<Person>>.Deserialize(path);
            return persons;
        }
    }
}
