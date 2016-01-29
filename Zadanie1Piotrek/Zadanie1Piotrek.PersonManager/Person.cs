using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Piotrek.PersonManager
{
    [Serializable]
    public class Person
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
                if (Validators.ValidatePesel(ref value))
                {
                    pesel = value;
                }

                else
                {
                   throw new Exception("Nieprawidłowy PESEL");
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
