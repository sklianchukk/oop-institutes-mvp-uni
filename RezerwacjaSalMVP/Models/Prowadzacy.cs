using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSalMVP.Models
{
    public class Prowadzacy
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }

        public Guid Id { get; }

        public Prowadzacy(string Imie, string Nazwisko, string email)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Email = email;
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }
    }
}
