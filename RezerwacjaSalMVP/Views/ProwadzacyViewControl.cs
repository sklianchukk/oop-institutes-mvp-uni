using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Views
{
    public partial class ProwadzacyViewControl : UserControl, IProwadzacyView
    {
        public ProwadzacyViewControl()
        {
            InitializeComponent();
            
            btnDodajProwadzacego.Click += (s, e) => DodajProwadzacegoClicked?.Invoke(this, EventArgs.Empty);
            btnUsunProwadzacego.Click += (s, e) => UsunProwadzacegoClicked?.Invoke(this, EventArgs.Empty);
        }

        public string Imie => txtImie.Text;
        public string Nazwisko => txtNazwisko.Text;
        public string Email => txtEmail.Text;
        
        public event EventHandler DodajProwadzacegoClicked;
        public event EventHandler UsunProwadzacegoClicked;
        
        public int WybranyIndeksProwadzacego => lbProwadzacy.SelectedIndex;

        public void WyswietlProwadzacych(List<Prowadzacy> prowadzacy)
        {
            lbProwadzacy.Items.Clear();
            foreach (var p in prowadzacy) lbProwadzacy.Items.Add($"{p.Imie} {p.Nazwisko} - {p.Email}");
        }

        public void PokazKomunikat(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
