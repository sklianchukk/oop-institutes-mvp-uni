using System;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Repsitories
{
    public class ProwadzacyRepository
    {
        private List<Prowadzacy> _prowadzacy = new List<Prowadzacy>();

        public void DodajProwadzacego(Prowadzacy prowadzacy)
        {
            if (prowadzacy == null) throw new ArgumentNullException(nameof(prowadzacy));
            _prowadzacy.Add(prowadzacy);
        }

        public void UsunProwadzacego(Prowadzacy prowadzacy)
        {
            _prowadzacy.Remove(prowadzacy);
        }

        public List<Prowadzacy> PobierzWszystkich()
        {
            return _prowadzacy;
        }
    }
}