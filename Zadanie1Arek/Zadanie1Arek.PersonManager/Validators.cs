using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek.PersonManager
{
    public class Validators   
    {
        public static bool IsDigit(string s)   
        {
            double temp;

            if (double.TryParse(s, out temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
            
        public static bool IsPersonNotEmpty(Person person)
        {
            if (person.FirstName != null && person.LastName != null && person.Age != 0 && person.Pesel != null && person.PhoneNumber != null)
            {
                return true;
            }
            return false;
        }           
    }
}

