using System;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;
using RezerwacjaSalMVP.Repsitories;
using RezerwacjaSalMVP.Views;

namespace RezerwacjaSalMVP.Presenters
{
    public class RezerwacjaPresenter
    {
        private readonly IRezerwacjaView _view;
        private readonly RezerwacjaRepository _rezerwacjaRepo;
        private readonly SalaRepository _salaRepo;
        private readonly ProwadzacyRepository _prowadzacyRepo;

        public RezerwacjaPresenter(
            IRezerwacjaView view, 
            RezerwacjaRepository rezerwacjaRepo, 
            SalaRepository salaRepo, 
            ProwadzacyRepository prowadzacyRepo)
        {
            _view = view;
            _rezerwacjaRepo = rezerwacjaRepo;
            _salaRepo = salaRepo;
            _prowadzacyRepo = prowadzacyRepo;

            _view.DodajRezerwacjeClicked += OnDodajRezerwacje;
            _view.UsunRezerwacjeClicked += OnUsunRezerwacje;

            OdswiezWidok();
        }

        private void OnUsunRezerwacje(object sender, EventArgs e)
        {
            var idx = _view.WybranyIndeksRezerwacji;
            var rezerwacje = _rezerwacjaRepo.PobierzWszystkie();
            if (idx >= 0 && idx < rezerwacje.Count)
            {
                _rezerwacjaRepo.UsunRezerwacje(rezerwacje[idx]);
                _view.PokazKomunikat("Usunięto rezerwację.");
                OdswiezWidok();
            }
            else
            {
                _view.PokazKomunikat("Wybierz rezerwację do usunięcia!");
            }
        }

        private void OnDodajRezerwacje(object sender, EventArgs e)
        {
            if (_view.WybranyProwadzacy == null || _view.WybranaSala == null)
            {
                _view.PokazKomunikat("Proszę wybrać salę i prowadzącego!");
                return;
            }

            if (_view.GodzinaRozpoczecia >= _view.GodzinaZakonczenia)
            {
                _view.PokazKomunikat("Godzina rozpoczęcia musi być wcześniejsza niż godzina zakończenia!");
                return;
            }

            var nowaRezerwacja = new Rezerwacja(
                _view.WybranyProwadzacy, 
                _view.WybranaSala, 
                _view.Data, 
                _view.GodzinaRozpoczecia, 
                _view.GodzinaZakonczenia);

            bool czyDodano = _rezerwacjaRepo.DodajRezerwacje(nowaRezerwacja);

            if (czyDodano)
            {
                _view.PokazKomunikat("Pomyślnie dodano rezerwację!");
                OdswiezWidok();
            }
            else
            {
                _view.PokazKomunikat("Błąd: Konflikt z inną rezerwacją w tym samym czasie dla tej sali.");
            }
        }

        public void OdswiezWidok()
        {
            _view.AktualizujListy(_salaRepo.PobierzWszystkie(), _prowadzacyRepo.PobierzWszystkich());
            _view.WyswietlRezerwacje(_rezerwacjaRepo.PobierzWszystkie());
        }
    }
}