using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Piotrek
{
    class ListPerson : IStorable
    {     
        List<Person> oListPerson = new List<Person>();
      
        public void AddPerson()
        {
           
            Console.WriteLine("Podaj imię: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string b = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj pesel: ");
            string d = Console.ReadLine();

            oListPerson.Add(new Person(a, b, c, d));


        }

        public void ShowPeople()
        {
            for (int i = 0; i < oListPerson.Count; i++)           
            {
                Console.WriteLine("IMIĘ I NAZWISKO: {0} {1}", oListPerson[i].Imie, oListPerson[i].Nazwisko );
                Console.WriteLine("WIEK: {0}", oListPerson[i].Wiek);
                Console.WriteLine("PESEL: {0}", oListPerson[i].Pesel);
                Console.WriteLine();
            }
          
        }
    }
}

