using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    internal class PersonsList : IStorable
    {
        private List<Person> persons = new List<Person>(); 
        
                          

        public void AddPerson(Person person)
        {
            Console.WriteLine("\nWprowadź dane nowej osoby.\n");
            Console.WriteLine("Podaj imię: ");
            string i = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string n = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj adres: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj pesel: ");
            string p = Console.ReadLine();
            Console.WriteLine("Podaj nr telefonu: ");
            string nt = Console.ReadLine();
            

            
            persons.Add(new Person(i, n, w, a, p, nt));
            
        }

       


        public void GetAllPersons()
        {
            Console.WriteLine("\nLISTA OSÓB");
            for (int i = 0; i < persons.Count; i++)
            {
                
                Console.WriteLine("\nOsoba {0}", i+1);
                Console.WriteLine("Imię: " + persons[i].FirstName + " ");
                Console.WriteLine("Name: " + persons[i].Name + " ");
                Console.WriteLine("Age: " + persons[i].Age + " ");
                Console.WriteLine("Address: " + persons[i].Address + " ");
                Console.WriteLine("Pesel: " + persons[i].Pesel + " ");
                Console.WriteLine("Nr telefonu: " + persons[i].PhoneNumber);
            }
            
        }
    }
}
