using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1Arek.PersonManager;

namespace Zadanie1Arek.ConsoleApp
{
    internal class ConsoleMenu
    {
        IStorable _storage;
        
        public ConsoleMenu(IStorable storage)
        {
            this._storage = storage;
        }

                             
        private Person ConsoleRead() 
        {
            Person personView = new Person();
           
            Console.WriteLine("Podaj imię: ");
            personView.FirstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            personView.LastName = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            personView.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pesel: ");
            personView.Pesel = Console.ReadLine();
            Console.WriteLine("Podaj nr telefonu: ");
            personView.PhoneNumber = Console.ReadLine();
                    
            return personView;
        }

        private void ConsoleView()  
        {
            if (_storage.GetAllPersons().Count<Person>() != 0)
            {
                Console.WriteLine("OSOBY ZNAJDUJĄCE SIĘ NA LIŚCIE TO: \n\r");

                foreach (var p in _storage.GetAllPersons())
                {
                    Console.WriteLine("Imię: " + p.FirstName);
                    Console.WriteLine("Nazwisko: " + p.LastName);
                    Console.WriteLine("Wiek: " + p.Age);
                    Console.WriteLine("Pesel: " + p.Pesel);
                    Console.WriteLine("Numer telefonu: " + p.PhoneNumber);
                }
            }
            else
            {
                Console.WriteLine("\nLista jest pusta. Uzupełnij ją!\n");
            } 
        }

        public void ShowMenu()
        {
            Console.WriteLine("MENU PROGRAMU\n\nWybierz jedną z opcji:\n1.Dodaj nową osobę\n2.Wyświetl wszystkie osoby\n3.Wyjście");

            try
            {
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        _storage.AddPerson(ConsoleRead());
                        ShowMenu();
                        break;
                    case 2:
                        ConsoleView();
                        ShowMenu();
                        break;
                    case 3:
                        Console.WriteLine("Do zobaczenia!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nWybierz jedną z opcji wskazaną w MENU!\n");
                        ShowMenu();
                        break;
                       
                }
            }
            catch (Exception)
            {

                Console.WriteLine("\nWybierz jedną z opcji wskazaną w MENU!\n");
                ShowMenu();
            }
           
        }
    }
}
