using System;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;
using RezerwacjaSalMVP.Repsitories;
using RezerwacjaSalMVP.Views;

namespace RezerwacjaSalMVP.Presenters
{
    public class ProwadzacyPresenter
    {
        private readonly IProwadzacyView _view;
        private readonly ProwadzacyRepository _repo;

        public ProwadzacyPresenter(IProwadzacyView view, ProwadzacyRepository repo)
        {
            _view = view;
            _repo = repo;

            _view.DodajProwadzacegoClicked += OnDodajProwadzacego;
            _view.UsunProwadzacegoClicked += OnUsunProwadzacego;
            OdswiezWidok();
        }

        private void OnUsunProwadzacego(object sender, EventArgs e)
        {
            var idx = _view.WybranyIndeksProwadzacego;
            var wszyscy = _repo.PobierzWszystkich();
            if (idx >= 0 && idx < wszyscy.Count)
            {
                _repo.UsunProwadzacego(wszyscy[idx]);
                _view.PokazKomunikat("Usunięto prowadzącego.");
                OdswiezWidok();
            }
            else
            {
                _view.PokazKomunikat("Wybierz prowadzącego do usunięcia!");
            }
        }

        private void OnDodajProwadzacego(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.Imie) || string.IsNullOrWhiteSpace(_view.Nazwisko) || string.IsNullOrWhiteSpace(_view.Email))
            {
                _view.PokazKomunikat("Proszę uzupełnić wszystkie dane.");
                return;
            }

            var prowadzacy = new Prowadzacy(_view.Imie, _view.Nazwisko, _view.Email);
            _repo.DodajProwadzacego(prowadzacy);

            _view.PokazKomunikat("Dodano prowadzącego.");
            OdswiezWidok();
        }

        public void OdswiezWidok()
        {
            _view.WyswietlProwadzacych(_repo.PobierzWszystkich());
        }
    }
}