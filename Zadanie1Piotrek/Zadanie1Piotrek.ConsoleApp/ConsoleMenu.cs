using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1Piotrek.PersonManager;

namespace Zadanie1Piotrek.ConsoleApp
{
    public class ConsoleMenu
    {
        IStorable _storage;
      
        public ConsoleMenu(IStorable storage)
        {
            this._storage = storage;
        }
        
        private void Add()
        {
            Person person = new Person();         
            Console.WriteLine("\n\rWprowadź dane nowej osoby.\n\r");
            Console.WriteLine("Podaj imię: ");
            person.Imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            person.Nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            person.Wiek = int.Parse(Console.ReadLine());         
            Console.WriteLine("Podaj pesel: ");
            try
            {
                person.Pesel = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Użytkownik nie zostanie dodany do bazy. Powód: {0}", ex.Message);
                return;
            }

            try
            {
                _storage.AddPerson(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void View()
        {
            List<Person> people = _storage.GetAllPersons();

            if (!people.Any())
            {
                Console.WriteLine("Lista jest pusta!");
                return;
            }
            foreach (var person in people)
            {
                Console.WriteLine("Imię: " + person.Imie);
                Console.WriteLine("Nazwisko: " + person.Nazwisko);
                Console.WriteLine("Wiek: " + person.Wiek);
                Console.WriteLine("Pesel: " + person.Pesel);
            }
        }
        public void Ul()
        {
            Console.WriteLine("MENU:\n1\r1- Dodaj osobę\n2- Wyświetl Listę osób\n3- Wyjście z Aplikacji");
            
       try
       {                
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
       catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Ul();
            }
        }
    }
}
