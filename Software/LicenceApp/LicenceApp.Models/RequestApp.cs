using System;

namespace LicenceApp.Models
{
    public class RequestApp
    {
        public int ID_zahtjev { get; set; }
        public int ID_korisnik { get; set; }
        public int ID_softver { get; set; }
        public int ID_uredaj { get; set; }
        public string Razlog_koristenja { get; set; }
        public DateTime Datum_podnosenja { get; set; }

        public override string ToString()
        {
            return $"Zahtjev #{ID_zahtjev} - {Datum_podnosenja:dd.MM.yyyy.}";
        }
    }
}