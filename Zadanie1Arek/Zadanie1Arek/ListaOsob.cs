using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    class ListaOsob : IStorable
    {
        List<Osoba> LOsob = new List<Osoba>();
        
                          

        public void DodajOsobe()
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
            

            Osoba oOsoba = new Osoba(i, n, w, a, p, nt);
            LOsob.Add(oOsoba);
            
        }

       


        public void PokazOsoby()
        {
            Console.WriteLine("\nLISTA OSÓB");
            for (int i = 0; i < LOsob.Count; i++)
            {
                
                Console.WriteLine("\nOsoba {0}", i+1);
                Console.WriteLine("Imię: " + LOsob[i].Imie + " ");
                Console.WriteLine("Nazwisko: " + LOsob[i].Nazwisko + " ");
                Console.WriteLine("Wiek: " + LOsob[i].Wiek + " ");
                Console.WriteLine("Adres: " + LOsob[i].Adres + " ");
                Console.WriteLine("Pesel: " + LOsob[i].Pesel + " ");
                Console.WriteLine("Nr telefonu: \n" + LOsob[i].NrTelefonu);
            }
            
        }
    }
}
