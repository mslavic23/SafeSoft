using System;

namespace LicenceApp.Models
{
    public class Zahtjev
    {
        public int ID_zahtjev { get; set; }
        public int ID_korisnik { get; set; }
        public int ID_softver { get; set; }
        public int ID_uredaj { get; set; }
        public string Razlog_koristenja { get; set; }
        public DateTime Datum_podnosenja { get; set; }
    }
}
