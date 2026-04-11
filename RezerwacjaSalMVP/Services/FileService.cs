using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using RezerwacjaSalMVP.Models;
using RezerwacjaSalMVP.Repsitories;

namespace RezerwacjaSalMVP.Services
{
    public class AppData
    {
        public List<Sala> Sale { get; set; } = new List<Sala>();
        public List<Prowadzacy> Prowadzacy { get; set; } = new List<Prowadzacy>();
        public List<Rezerwacja> Rezerwacje { get; set; } = new List<Rezerwacja>();
    }

    public class FileService
    {
        private readonly string _filePath = "dane_aplikacji.json";

        public void ZapiszDane(SalaRepository saleRepo, ProwadzacyRepository prowadzacyRepo, RezerwacjaRepository rezerwacjeRepo)
        {
            var data = new AppData
            {
                Sale = saleRepo.PobierzWszystkie(),
                Prowadzacy = prowadzacyRepo.PobierzWszystkich(),
                Rezerwacje = rezerwacjeRepo.PobierzWszystkie()
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(_filePath, json);
        }

        public void WczytajDane(SalaRepository saleRepo, ProwadzacyRepository prowadzacyRepo, RezerwacjaRepository rezerwacjeRepo)
        {
            if (!File.Exists(_filePath)) return;
            try 
            {
                string json = File.ReadAllText(_filePath);
                var data = JsonSerializer.Deserialize<AppData>(json);

                if (data != null)
                {
                    foreach (var s in data.Sale) saleRepo.DodajSale(s);
                    foreach (var p in data.Prowadzacy) prowadzacyRepo.DodajProwadzacego(p);
                    foreach (var r in data.Rezerwacje) rezerwacjeRepo.DodajRezerwacje(r);
                }
            }
            catch (JsonException ex)
            { }
            catch (System.Exception ex) { }
            
        }
    }
}