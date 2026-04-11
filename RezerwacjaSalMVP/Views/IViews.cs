using System;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Views
{
    public interface ISalaView
    {
        string NazwaWydzialu { get; }
        string UlicaWydzialu { get; }
        string MiastoWydzialu { get; }
        string NumerSali { get; }
        int IloscMiejsc { get; }
        Sala.TypSali Typ { get; }

        event EventHandler DodajSaleClicked;
        event EventHandler UsunSaleClicked;
        int WybranyIndeksSali { get; }

        void WyswietlSale(List<Sala> sale);
        void PokazKomunikat(string message);
    }

    public interface IProwadzacyView
    {
        string Imie { get; }
        string Nazwisko { get; }
        string Email { get; }

        event EventHandler DodajProwadzacegoClicked;
        event EventHandler UsunProwadzacegoClicked;
        int WybranyIndeksProwadzacego { get; }

        void WyswietlProwadzacych(List<Prowadzacy> prowadzacy);
        void PokazKomunikat(string message);
    }

    public interface IRezerwacjaView
    {
        Prowadzacy WybranyProwadzacy { get; }
        Sala WybranaSala { get; }
        DateTime Data { get; }
        TimeSpan GodzinaRozpoczecia { get; }
        TimeSpan GodzinaZakonczenia { get; }

        event EventHandler DodajRezerwacjeClicked;
        event EventHandler UsunRezerwacjeClicked;
        int WybranyIndeksRezerwacji { get; }

        void AktualizujListy(List<Sala> sale, List<Prowadzacy> prowadzacy);
        void WyswietlRezerwacje(List<Rezerwacja> rezerwacje);
        void PokazKomunikat(string message);
    }
}