namespace LicenceApp.Models
{
    public class Device
    {
        public int ID_uredaj { get; set; }
        public string Naziv_racunala { get; set; }
        public string Lokacija { get; set; }
        public string Tip_uredaja { get; set; }

        public override string ToString()
        {
            return $"{Naziv_racunala} - {Lokacija} - {Tip_uredaja}";
        }
    }
}

