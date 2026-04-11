using RezerwacjaSalMVP.Repsitories;
using RezerwacjaSalMVP.Services;

namespace RezerwacjaSalMVP.Models
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Tworzymy główne obiekty i repozytoria
            var salaRepo = new SalaRepository();
            var prowadzacyRepo = new ProwadzacyRepository();
            var rezerwacjaRepo = new RezerwacjaRepository();

            var fileService = new FileService();

            // Wczytujemy dane
            fileService.WczytajDane(salaRepo, prowadzacyRepo, rezerwacjaRepo);

            // Konfigurujemy Główne Okno
            var form1 = new MainForm();
            form1.ZainicjujAplikacje(salaRepo, prowadzacyRepo, rezerwacjaRepo);

            // Rejestrujemy zapis przed zamknięciem aplikacji:
            Application.ApplicationExit += (sender, e) =>
            {
                fileService.ZapiszDane(salaRepo, prowadzacyRepo, rezerwacjaRepo);
            };

            Application.Run(form1);
        }
    }
}