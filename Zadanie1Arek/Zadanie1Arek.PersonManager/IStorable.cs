using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek.PersonManager
{
    public interface IStorable
    {
        void AddPerson(Person person);
        List<Person> GetAllPersons();
    }
}
