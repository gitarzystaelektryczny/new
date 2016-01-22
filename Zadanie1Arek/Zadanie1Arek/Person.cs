using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Pesel { get; set; }
        public string  PhoneNumber { get; set; }

        public Person()
        {

        }

        public Person(string _firstName, string _name, int _age, string _address, string _pesel, string _phoneNumber)
        {
            FirstName = _firstName;
            Name = _name;
            Age = _age;
            Address = _address;
            Pesel = _pesel;
            PhoneNumber = _phoneNumber;
        }


    }
}
