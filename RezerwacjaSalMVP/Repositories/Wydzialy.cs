using System;
using System.Collections.Generic;
using System.Text;

using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Repsitories
{
    public class WydzialyRepository
    {
        private List<Wydzial> _wydzialy = new List<Wydzial>();

        public void DodajWydzial(Wydzial wydzial)
        {
            if (wydzial == null)
                throw new ArgumentNullException(nameof(wydzial));

            _wydzialy.Add(wydzial);
        }

        public List<Wydzial> PobierzWszystkie()
        {
            return _wydzialy;
        }
    }
}
