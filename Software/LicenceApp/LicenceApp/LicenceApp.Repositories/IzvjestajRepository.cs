using System;
using System.Collections.Generic;
using System.Linq;

namespace LicenceApp.Repositories
{
    public class ReportLine
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Software { get; set; }
        public string Version { get; set; }
        public string LicenceType { get; set; }
        public string Device { get; set; }
        public string Location { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public int TotalSeats { get; set; }
        public int OccupiedSeats { get; set; }
        public int AvailableSeats { get; set; }
    }

    public class IzvjestajRepository
    {
        private readonly ZahtjevRepository _zahtjevRepository = new ZahtjevRepository();
        private readonly KorisnikRepository _korisnikRepository = new KorisnikRepository();
        private readonly SoftverRepository _softverRepository = new SoftverRepository();
        private readonly UredajRepository _uredajRepository = new UredajRepository();

        public List<ReportLine> GetReport(DateTime? od = null, DateTime? do_ = null)
        {
            var zahtjevi = _zahtjevRepository.GetAll();
            var korisnici = _korisnikRepository.GetAll();
            var softveri = _softverRepository.GetAll();
            var uredaji = _uredajRepository.GetAll();

            var query = (from z in zahtjevi
                         join k in korisnici on z.ID_korisnik equals k.ID_korisnik
                         join s in softveri on z.ID_softver equals s.ID_softver
                         join u in uredaji on z.ID_uredaj equals u.ID_uredaj
                         select new ReportLine
                         {
                             Id = z.ID_zahtjev,
                             User = k.Ime + " " + k.Prezime,
                             Software = s.Naziv,
                             Version = s.Verzija,
                             LicenceType = s.Tip_licence,
                             Device = u.Naziv_racunala,
                             Location = u.Lokacija,
                             Reason = z.Razlog_koristenja,
                             Date = z.Datum_podnosenja,
                             TotalSeats = s.Ukupno_mjesta,
                             OccupiedSeats = zahtjevi.Count(zz => zz.ID_softver == s.ID_softver),
                             AvailableSeats = s.Ukupno_mjesta - zahtjevi.Count(zz => zz.ID_softver == s.ID_softver)
                         }).AsQueryable();

            if (od.HasValue)
                query = query.Where(x => x.Date >= od.Value);
            if (do_.HasValue)
                query = query.Where(x => x.Date <= do_.Value);

            return query.ToList();
        }
    }
}