using System;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;
using RezerwacjaSalMVP.Repsitories;
using RezerwacjaSalMVP.Views;

namespace RezerwacjaSalMVP.Presenters
{
    public class SalaPresenter
    {
        private readonly ISalaView _view;
        private readonly SalaRepository _repo;

        public SalaPresenter(ISalaView view, SalaRepository repo)
        {
            _view = view;
            _repo = repo;

            // Subskrypcja zdarzenia z widoku
            _view.DodajSaleClicked += OnDodajSale;
            _view.UsunSaleClicked += OnUsunSale;

            // Inicjalne załadowanie danych
            OdswiezWidok();
        }

        private void OnUsunSale(object sender, EventArgs e)
        {
            var idx = _view.WybranyIndeksSali;
            var sale = _repo.PobierzWszystkie();
            if (idx >= 0 && idx < sale.Count)
            {
                _repo.UsunSale(sale[idx]);
                _view.PokazKomunikat("Usunięto salę pomyślnie.");
                OdswiezWidok();
            }
            else
            {
                _view.PokazKomunikat("Wybierz salę do usunięcia!");
            }
        }

        private void OnDodajSale(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_view.NazwaWydzialu) || string.IsNullOrWhiteSpace(_view.NumerSali) || 
                    string.IsNullOrWhiteSpace(_view.UlicaWydzialu) || string.IsNullOrWhiteSpace(_view.MiastoWydzialu))
                {
                    _view.PokazKomunikat("Wypełnij wszystkie pola dla sali!");
                    return;
                }

                var adres = new Adress
                {
                    Ulica = _view.UlicaWydzialu,
                    Miasto = _view.MiastoWydzialu,
                };

                var wydzial = new Wydzial(_view.NazwaWydzialu, adres);
                var sala = new Sala(wydzial, _view.NumerSali, _view.IloscMiejsc, _view.Typ);

                _repo.DodajSale(sala);

                _view.PokazKomunikat("Dodano salę pomyślnie.");
                OdswiezWidok();
            }
            catch (Exception ex)
            {
                _view.PokazKomunikat($"Wystąpił błąd: {ex.Message}");
            }
        }

        public void OdswiezWidok()
        {
            _view.WyswietlSale(_repo.PobierzWszystkie());
        }
    }
}