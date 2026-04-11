using System;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Repsitories
{
    public class SalaRepository
    {
        private List<Sala> _sale = new List<Sala>();

        public void DodajSale(Sala sala)
        {
            if (sala == null) throw new ArgumentNullException(nameof(sala));
            _sale.Add(sala);
        }

        public void UsunSale(Sala sala)
        {
            _sale.Remove(sala);
        }

        public List<Sala> PobierzWszystkie()
        {
            return _sale;
        }
    }
}