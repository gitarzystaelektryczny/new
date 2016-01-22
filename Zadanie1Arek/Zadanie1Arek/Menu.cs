using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    internal class Menu
    {
        
        private MemoryStorage person = new MemoryStorage();
        private MemoryStorage person2 = new MemoryStorage();
        private Person personRead = new Person();
        //stworzyć nową klasę wykonującą wpisywanie/wypisywanie z konsoli
        //a może tylko metodę?
        //"zapełnimy" w niej obiekt person danymi z konsoli i przekażemy dalej

        public void ShowMenu()
        {
            Console.WriteLine("\nMENU PROGRAMU\n\nWybierz jedną z opcji:\n1.Dodaj nową osobę\n2.Wyświetl wszystkie osoby\n3.Wyjście");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    person.AddPerson(Read());  //czy dobra nazwa? WAŻNE
                    ShowMenu();
                    break;
                case 2:
                    Write();
                    ShowMenu();
                    break;
                case 3:
                    Console.WriteLine("No i działa mały sqrczybyk!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Co jest?");
                    break;
            }
        }

        

        private Person Read() //metoda czytająca
        {
            Console.WriteLine("Podaj imię: ");
            personRead.FirstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            personRead.Name = Console.ReadLine();
            Console.WriteLine("Podaj wiek: ");
            personRead.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj adres: ");
            personRead.Address = Console.ReadLine();
            Console.WriteLine("Podaj pesel: ");
            personRead.Pesel = Console.ReadLine();
            Console.WriteLine("Podaj nr telefonu: ");
            personRead.PhoneNumber = Console.ReadLine();

            return personRead;
        }

        private void Write()   //metoda wypisująca
        {
            
            
        }
    }
}
