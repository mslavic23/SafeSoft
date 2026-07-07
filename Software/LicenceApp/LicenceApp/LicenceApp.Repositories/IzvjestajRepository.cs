using System;
using System.Collections.Generic;
using System.Linq;

namespace LicenceApp.Repositories
{
    public class IzvjestajStavka
    {
        public int ID { get; set; }
        public string Korisnik { get; set; }
        public string Softver { get; set; }
        public string Verzija { get; set; }
        public string Uredaj { get; set; }
        public string Lokacija { get; set; }
        public string Razlog { get; set; }
        public DateTime Datum { get; set; }
        public int UkupnoMjesta { get; set; }
        public int ZauzetaMjesta { get; set; }
        public int SlobodnaMjesta { get; set; }
    }

    public class IzvjestajRepository
    {
        private readonly ZahtjevRepository _zahtjevRepository = new ZahtjevRepository();
        private readonly KorisnikRepository _korisnikRepository = new KorisnikRepository();
        private readonly SoftverRepository _softverRepository = new SoftverRepository();
        private readonly UredajRepository _uredajRepository = new UredajRepository();

        public List<IzvjestajStavka> DohvatiIzvjestaj(DateTime? od = null, DateTime? do_ = null)
        {
            var zahtjevi = _zahtjevRepository.DohvatiSve();
            var korisnici = _korisnikRepository.DohvatiSve();
            var softveri = _softverRepository.DohvatiSve();
            var uredaji = _uredajRepository.DohvatiSve();

            var query = (from z in zahtjevi
                         join k in korisnici on z.ID_korisnik equals k.ID_korisnik
                         join s in softveri on z.ID_softver equals s.ID_softver
                         join u in uredaji on z.ID_uredaj equals u.ID_uredaj
                         select new IzvjestajStavka
                         {
                             ID = z.ID_zahtjev,
                             Korisnik = k.Ime + " " + k.Prezime,
                             Softver = s.Naziv,
                             Verzija = s.Verzija,
                             Uredaj = u.Naziv_racunala,
                             Lokacija = u.Lokacija,
                             Razlog = z.Razlog_koristenja,
                             Datum = z.Datum_podnosenja,
                             UkupnoMjesta = s.Ukupno_mjesta,
                             ZauzetaMjesta = zahtjevi.Count(zz => zz.ID_softver == s.ID_softver),
                             SlobodnaMjesta = s.Ukupno_mjesta - zahtjevi.Count(zz => zz.ID_softver == s.ID_softver)
                         }).AsQueryable();

            if (od.HasValue)
                query = query.Where(x => x.Datum >= od.Value);
            if (do_.HasValue)
                query = query.Where(x => x.Datum <= do_.Value);

            return query.ToList();
        }
    }
}
