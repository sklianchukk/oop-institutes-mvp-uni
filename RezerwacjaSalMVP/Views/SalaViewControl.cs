using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Views
{
    public partial class SalaViewControl : UserControl, ISalaView
    {
        public SalaViewControl()
        {
            InitializeComponent();
            cbTypSali.DataSource = Enum.GetValues(typeof(Sala.TypSali));
            
            btnDodajSale.Click += (s, e) => DodajSaleClicked?.Invoke(this, EventArgs.Empty);
            btnUsunSale.Click += (s, e) => UsunSaleClicked?.Invoke(this, EventArgs.Empty);
        }

        public string NazwaWydzialu => txtNazwaWydzialu.Text;
        public string UlicaWydzialu => txtUlica.Text;
        public string MiastoWydzialu => txtMiasto.Text;
        public string NumerSali => txtNumerSali.Text;
        public int IloscMiejsc => (int)numIloscMiejsc.Value;
        public Sala.TypSali Typ => (Sala.TypSali)cbTypSali.SelectedItem;

        public event EventHandler DodajSaleClicked;
        public event EventHandler UsunSaleClicked;
        public int WybranyIndeksSali => lbSale.SelectedIndex;

        public void WyswietlSale(List<Sala> sale)
        {
            lbSale.Items.Clear();
            foreach (var s in sale) lbSale.Items.Add($"Wydział: {s.Wydzial?.Nazwa} ({s.Wydzial?.Adres?.Miasto}), Sala: {s.Numer} [{s.Typ}]");
        }

        public void PokazKomunikat(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
