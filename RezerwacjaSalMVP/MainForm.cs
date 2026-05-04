using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RezerwacjaSalMVP.Models;
using RezerwacjaSalMVP.Presenters;
using RezerwacjaSalMVP.Repsitories;
using RezerwacjaSalMVP.Views;

namespace RezerwacjaSalMVP
{
    public partial class MainForm : Form
    {
        private SalaPresenter? _salaPresenter;
        private ProwadzacyPresenter? _prowadzacyPresenter;
        private RezerwacjaPresenter? _rezerwacjaPresenter;

        private SalaViewControl _salaView;
        private ProwadzacyViewControl _prowadzacyView;
        private RezerwacjaViewControl _rezerwacjaView;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ZainicjujAplikacje(SalaRepository salaRepo, ProwadzacyRepository prowadzacyRepo, RezerwacjaRepository rezerwacjaRepo)
        {
            _salaView = new SalaViewControl { Dock = DockStyle.Fill };
            _prowadzacyView = new ProwadzacyViewControl { Dock = DockStyle.Fill };
            _rezerwacjaView = new RezerwacjaViewControl { Dock = DockStyle.Fill };

            tabSale.Controls.Add(_salaView);
            tabProwadzacy.Controls.Add(_prowadzacyView);
            tabRezerwacje.Controls.Add(_rezerwacjaView);

            _salaPresenter = new SalaPresenter(_salaView, salaRepo);
            _prowadzacyPresenter = new ProwadzacyPresenter(_prowadzacyView, prowadzacyRepo);
            _rezerwacjaPresenter = new RezerwacjaPresenter(_rezerwacjaView, rezerwacjaRepo, salaRepo, prowadzacyRepo);


            tabControl1.SelectedIndexChanged += (s, e) =>
            {
                if (tabControl1.SelectedTab == tabProwadzacy)
                {
                    _prowadzacyPresenter.OdswiezWidok();
                }
                else if (tabControl1.SelectedTab == tabSale)
                {
                    _salaPresenter.OdswiezWidok();
                }
                else if (tabControl1.SelectedTab == tabRezerwacje)
                {
                    _rezerwacjaPresenter.OdswiezWidok();
                }
            };
        }
    }
}
