﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek.PersonManager
{
    public class MemoryStorage : IStorable
    {
        private List<Person> persons = new List<Person>();                         

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
