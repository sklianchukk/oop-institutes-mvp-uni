using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RezerwacjaSalMVP.Models;

namespace RezerwacjaSalMVP.Views
{
    public partial class RezerwacjaViewControl : UserControl, IRezerwacjaView
    {
        public RezerwacjaViewControl()
        {
            InitializeComponent();
            
            btnDodajRezerwacje.Click += (s, e) => DodajRezerwacjeClicked?.Invoke(this, EventArgs.Empty);
            btnUsunRezerwacje.Click += (s, e) => UsunRezerwacjeClicked?.Invoke(this, EventArgs.Empty);
        }

        public Prowadzacy WybranyProwadzacy => (Prowadzacy)cbWybranyProwadzacy.SelectedItem;
        public Sala WybranaSala => (Sala)cbWybranaSala.SelectedItem;
        public DateTime Data => dtpData.Value.Date;
        public TimeSpan GodzinaRozpoczecia => dtpOd.Value.TimeOfDay;
        public TimeSpan GodzinaZakonczenia => dtpDo.Value.TimeOfDay;
        
        public event EventHandler DodajRezerwacjeClicked;
        public event EventHandler UsunRezerwacjeClicked;
        
        public int WybranyIndeksRezerwacji => lbRezerwacje.SelectedIndex;

        public void AktualizujListy(List<Sala> sale, List<Prowadzacy> prowadzacy)
        {
            ActualizeComboBox(cbWybranaSala, sale);
            ActualizeComboBox(cbWybranyProwadzacy, prowadzacy);
        }

        public void WyswietlRezerwacje(List<Rezerwacja> rezerwacje)
        {
            lbRezerwacje.Items.Clear();
            foreach (var r in rezerwacje)
            {
                lbRezerwacje.Items.Add($"{r.Data:yyyy-MM-dd} {r.GodzinaRozpoczecia:hh\\:mm}-{r.GodzinaZakonczenia:hh\\:mm} | Sala: {r.Sala.Numer} | {r.Prowadzacy.Nazwisko}");
            }
        }

        public void PokazKomunikat(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizeComboBox<T>(ComboBox cb, List<T> list)
        {
            if (list == null) return;
            var selected = cb.SelectedItem;
            cb.DataSource = null;
            cb.DataSource = list;
            if (selected != null && list.Contains((T)selected))
            {
                cb.SelectedItem = selected;
            }
        }
    }
}
