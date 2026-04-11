using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSalMVP.Models
{
    public class Wydzial
    {
        public string Nazwa { get; set; }
        public Adress Adres { get; set; }

        public Wydzial() { }

        public Wydzial(string nazwa, Adress adres)
        {
            this.Nazwa = nazwa;
            this.Adres = adres;
        }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}
