﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    interface IStorable
    {
        List<Person> GetAllPersons;
        void AddPerson(Person person);
    }
}
