using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1Arek
{
    class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Adres { get; set; }
        public string Pesel { get; set; }
        public string  NrTelefonu { get; set; }

        public Osoba(string imie, string nazwisko, int wiek, string adres, string pesel, string nrTelefonu)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Adres = adres;
            Pesel = pesel;
            NrTelefonu = nrTelefonu;
        }


    }
}
