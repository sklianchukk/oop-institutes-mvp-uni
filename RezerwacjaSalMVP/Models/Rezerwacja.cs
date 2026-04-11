using System;
using System.Collections.Generic;
using System.Text;

namespace RezerwacjaSalMVP.Models
{
    public class Rezerwacja
    {
        public Prowadzacy Prowadzacy { get; set; }
        public Sala Sala { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan GodzinaRozpoczecia { get; set; }
        public TimeSpan GodzinaZakonczenia { get; set; }
        public Rezerwacja(Prowadzacy prowadzacy, Sala sala, DateTime data, TimeSpan godzinaRozpoczecia, TimeSpan godzinaZakonczenia)
        {
            Prowadzacy = prowadzacy;
            Sala = sala;
            Data = data;
            GodzinaRozpoczecia = godzinaRozpoczecia;
            GodzinaZakonczenia = godzinaZakonczenia;
        }
    }
}
