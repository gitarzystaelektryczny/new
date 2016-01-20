using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    internal class Menu
    {
        
        private PersonsList person = new PersonsList();
        

        public void ShowMenu()
        {
            Console.WriteLine("\nMENU PROGRAMU\n\nWybierz jedną z opcji:\n1.Dodaj nową osobę\n2.Wyświetl wszystkie osoby\n3.Wyjście");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    person.AddPerson();
                    ShowMenu();
                    break;
                case 2:
                    person.GetAllPersons();
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
    }
}
