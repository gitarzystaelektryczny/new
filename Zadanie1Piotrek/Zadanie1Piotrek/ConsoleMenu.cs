using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Piotrek
{
    public class ConsoleMenu
    {
        MemoryStorage people = new MemoryStorage();    
            
        private void Add()
        {            
            Console.WriteLine("\n\rWprowadź dane nowej osoby.\n\r");
            Console.WriteLine("Podaj imię: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            string b = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            int c = int.Parse(Console.ReadLine());         
            Console.WriteLine("Podaj pesel: ");
            string d = Console.ReadLine();

            people.AddPerson(new Person(a,b,c,d));
            //TODO: wyrzucić lokalne pola abcd
        }
        private void View()
        {
            foreach (var person in people.GetAllPersons())
            {
                Console.WriteLine("Imię: " + person.Imie);
                Console.WriteLine("Nazwisko: " + person.Nazwisko);
                Console.WriteLine("Wiek: " + person.Wiek);
                Console.WriteLine("Pesel: " + person.Pesel);
            }
        }
        public void Ul()
        {
            //TODO: Zabezpieczyć menu!
            Console.WriteLine("MENU:\n1\r1- Dodaj osobę\n2- Wyświetl Listę osób\n3- Wyjście z Aplikacji");
            int i = int.Parse(Console.ReadLine());


            switch (i)
            {
                case 1:
                    Add();
                    Ul();
                    break;
                case 2:
                    View();                   
                    Ul();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Ul();
                    break;
            }
        }
    }
}
