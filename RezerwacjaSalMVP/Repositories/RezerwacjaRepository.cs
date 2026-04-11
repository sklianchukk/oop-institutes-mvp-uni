using System;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Repsitories
{
    public class RezerwacjaRepository
    {
        private List<Rezerwacja> _rezerwacje = new List<Rezerwacja>();

        // Zwraca bool (lub może rzucać wyjątek), aby poinformować o ewentualnym konflikcie.
        public bool DodajRezerwacje(Rezerwacja nowaRezerwacja)
        {
            if (nowaRezerwacja == null) throw new ArgumentNullException(nameof(nowaRezerwacja));

            // Sprawdzanie konfliktów dla tej samej sali na ten sam dzień
            bool czyJestKonflikt = CzyKoliduje(nowaRezerwacja);

            if (czyJestKonflikt)
            {
                return false; // Konflikt z inną rezerwacją - nie dodajemy
            }

            _rezerwacje.Add(nowaRezerwacja);
            return true;
        }

        public void UsunRezerwacje(Rezerwacja rezerwacja)
        {
            _rezerwacje.Remove(rezerwacja);
        }

        public List<Rezerwacja> PobierzWszystkie()
        {
            return _rezerwacje;
        }

        private bool CzyKoliduje(Rezerwacja nowaRezerwacja)
        {
            foreach (var istniejaca in _rezerwacje)
            {
                // Sprawdzamy czy to ta sama sala i ta sama data
                if (istniejaca.Sala.Numer == nowaRezerwacja.Sala.Numer && 
                    istniejaca.Sala.Wydzial == nowaRezerwacja.Sala.Wydzial &&
                    istniejaca.Data.Date == nowaRezerwacja.Data.Date)
                {
                    // Sprawdzanie czy przedziały czasowe na siebie nachodzą
                    // Warunek: (Start1 < Koniec2) && (Start2 < Koniec1)
                    if (nowaRezerwacja.GodzinaRozpoczecia < istniejaca.GodzinaZakonczenia &&
                        istniejaca.GodzinaRozpoczecia < nowaRezerwacja.GodzinaZakonczenia)
                    {
                        return true; // Jest konflikt
                    }
                }
            }
            return false;
        }
    }
}