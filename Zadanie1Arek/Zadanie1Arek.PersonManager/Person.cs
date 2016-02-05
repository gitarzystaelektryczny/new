using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie1Arek.PersonManager
{
    //[Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }

        public Person() { }
    }
}
