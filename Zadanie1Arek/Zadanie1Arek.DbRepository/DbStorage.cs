using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1Arek.PersonManager;
using System.Data.Entity;

namespace Zadanie1Arek.DbRepository
{
    public class DbStorage : IStorable
    {
        

        public void AddPerson(PersonManager.Person person)
        {
            using (DatabaseEntities context = new DatabaseEntities())
            {
                context.People.Add(new Person()
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    Age = Convert.ToByte(person.Age),
                    Pesel = person.Pesel,
                    PhoneNumber = person.PhoneNumber,
                    EditDate = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        public List<PersonManager.Person> GetAllPersons()
        {
            List<PersonManager.Person> persons = new List<PersonManager.Person>();
            using (DatabaseEntities context = new DatabaseEntities())
            {
                var temp = context.People.ToList();
                foreach (var i in temp)
                {
                    PersonManager.Person person = new PersonManager.Person();
                    person.FirstName = i.FirstName;
                    person.LastName = i.LastName;
                    person.Age = i.Age;
                    person.Pesel = i.Pesel;
                    person.PhoneNumber = i.PhoneNumber;
                    persons.Add(person);
                }
            }
            return persons;
        }
    }
}
