using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    internal class ConsolMenu
    { 
        private MemoryStorage person = new MemoryStorage();
        
        private Person ConsoleRead() 
        {
            Person personView = new Person();
           
            Console.WriteLine("Podaj imię: ");
            personView.FirstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            personView.Name = Console.ReadLine();

            Console.WriteLine("Podaj wiek: ");
            string _age = Console.ReadLine();
            personView.Age = ConsolValidators.ToInteger(_age);

            Console.WriteLine("Podaj pesel: ");
            string _pesel = Console.ReadLine();
            personView.Pesel = ConsolValidators.IsInteger(_pesel);

            Console.WriteLine("Podaj nr telefonu: ");
            string _phone = Console.ReadLine();
            personView.PhoneNumber = ConsolValidators.IsInteger(_phone);

            return personView;
        }

        private void ConsoleView()  
        {
            if (person.GetAllPersons().Count<Person>() != 0)
            {
                Console.WriteLine("OSOBY ZNAJDUJĄCE SIĘ NA LIŚCIE TO: \n\r");

                foreach (var person in person.GetAllPersons())
                {
                    Console.WriteLine("Imię: " + person.FirstName);
                    Console.WriteLine("Nazwisko: " + person.Name);
                    Console.WriteLine("Wiek: " + person.Age);
                    Console.WriteLine("Pesel: " + person.Pesel);
                    Console.WriteLine("Numer telefonu: " + person.PhoneNumber);
                }
            }
            else
            {
                ConsolValidators.ColourStatement("\nLista jest obecnie pusta. Uzupełnij ją!\n");
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
                        person.AddPerson(ConsoleRead());
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
                        ConsolValidators.ColourStatement("\nWybierz jedną z opcji wskazaną w MENU!\n");
                        ShowMenu();
                        break;
                       
                }
            }
            catch (Exception)
            {

                ConsolValidators.ColourStatement("\nWybierz jedną z opcji wskazaną w MENU!\n");
                ShowMenu();
            }
           
        }
    }
}
