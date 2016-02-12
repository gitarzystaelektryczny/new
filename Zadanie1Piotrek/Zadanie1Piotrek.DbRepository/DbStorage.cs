using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1Piotrek.PersonManager;

namespace Zadanie1Piotrek.DbRepository
{
    public class DbStorage : IStorable
    {
        public void AddPerson(Zadanie1Piotrek.PersonManager.Person person)
        {
            using (DatabaseEntities context = new DatabaseEntities())
            {
                context.People.Add(new Person()
                {
                    FirstName = person.Imie,
                    LastName = person.Nazwisko,
                    Age = Convert.ToByte(person.Wiek),
                    Pesel = person.Pesel,
                    EditDate = DateTime.Now
                });
                context.SaveChanges();
            }
        }

        public List<Zadanie1Piotrek.PersonManager.Person> GetAllPersons()
        {
            List<Zadanie1Piotrek.PersonManager.Person> people = new List<Zadanie1Piotrek.PersonManager.Person>();
            
            using (DatabaseEntities context = new DatabaseEntities())
            {
                var dbList = context.People.ToList();
                foreach (var i in dbList)
                {
                    Zadanie1Piotrek.PersonManager.Person person = new Zadanie1Piotrek.PersonManager.Person();
                    person.Imie = i.FirstName;
                    person.Nazwisko = i.LastName;
                    person.Wiek = i.Age;
                    person.Pesel = i.Pesel;
                    people.Add(person);
                }
            }
            return people;
        }
    }
}
