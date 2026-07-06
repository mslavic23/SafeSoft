namespace LicenceApp.Models
{
    public class Korisnik
    {
        public int ID_korisnik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string LozinkaHash { get; set; }
        public string Uloga { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}