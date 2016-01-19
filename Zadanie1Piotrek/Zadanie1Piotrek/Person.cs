using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Piotrek
{
    class Person
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }   
        private string pesel;
        public string Pesel
        {
            get { return pesel; }
            set
            {
                if (value.Length == 11)
                    {
                        pesel = value;
                    }
                else
                    {
                        Console.WriteLine("Błąd! Wprowadziłeś {0} znaków. Wprowadź 11 cyfrowy numer PESEL", 
                                            value.Length);
                    }
            }
                
        }




        public Person() { }
        public Person(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }
        public Person(string imie, string nazwisko, int wiek, string pesel) : this(imie, nazwisko, wiek)
        {

            Pesel = pesel;
        }

    }
}
