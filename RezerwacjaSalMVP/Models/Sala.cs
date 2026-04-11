using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSalMVP.Models
{
    public class Sala
    {
        public Wydzial Wydzial { get; set; }
        public string Numer { get; set; }
        public int IloscMiejsc { get; set; }
        public enum TypSali { Komputerowa, Cwiczeniowa, Wykladowa }
        public TypSali Typ { get; set; }

        public Sala() { }

        public Sala(Wydzial wydzial, string numer, int iloscMiejsc, TypSali typ)
        {
            this.Wydzial = wydzial;
            this.Numer = numer;
            this.IloscMiejsc = iloscMiejsc;
            this.Typ = typ;
        }

        public override string ToString()
        {
            return Wydzial?.Nazwa + " " + Numer;
        }
    }
}

