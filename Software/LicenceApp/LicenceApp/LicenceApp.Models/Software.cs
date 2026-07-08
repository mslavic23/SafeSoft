namespace LicenceApp.Models
{
    public class Software
    {
        public int ID_softver { get; set; }
        public string Naziv { get; set; }
        public string Verzija { get; set; }
        public string Tip_licence { get; set; }
        public int Ukupno_mjesta { get; set; }

        public override string ToString()
        {
            return $"{Naziv} {Verzija} - {Tip_licence} - {Ukupno_mjesta} mjesta";
        }
    }
}

