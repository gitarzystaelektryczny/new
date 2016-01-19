using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    class PokazMenu
    {
        
        ListaOsob oOsoba = new ListaOsob();
        

        public void Wyswietl()
        {
            Console.WriteLine("\nMENU PROGRAMU\n\nWybierz jedną z opcji:\n1.Dodaj nową osobę\n2.Wyświetl wszystkie osoby\n3.Wyjście");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    oOsoba.DodajOsobe();
                    Wyswietl();
                    break;
                case 2:
                    oOsoba.PokazOsoby();
                    Wyswietl();
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
