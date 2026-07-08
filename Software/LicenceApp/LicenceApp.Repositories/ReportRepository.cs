using System;
using System.Collections.Generic;
using System.Linq;
using LicenceApp.Helpers;

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

    public class ReportRepository
    {
        private readonly RequestAppRepository _requestRepository = new RequestAppRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly SoftwareRepository _softwareRepository = new SoftwareRepository();
        private readonly DeviceRepository _deviceRepository = new DeviceRepository();

        public List<ReportLine> GetReport(DateTime? from = null, DateTime? to = null)
        {
            var requests = _requestRepository.GetAll();
            var users = _userRepository.GetAll();
            var softwares = _softwareRepository.GetAll();
            var devices = _deviceRepository.GetAll();

            var query = (from r in requests
                         join u in users on r.ID_korisnik equals u.ID_korisnik
                         join s in softwares on r.ID_softver equals s.ID_softver
                         join d in devices on r.ID_uredaj equals d.ID_uredaj
                         select new ReportLine
                         {
                             Id = r.ID_zahtjev,
                             User = u.Ime + " " + u.Prezime,
                             Software = s.Naziv,
                             Version = s.Verzija,
                             LicenceType = s.Tip_licence,
                             Device = d.Naziv_racunala,
                             Location = d.Lokacija,
                             Reason = r.Razlog_koristenja,
                             Date = r.Datum_podnosenja,
                             TotalSeats = s.Ukupno_mjesta,
                             OccupiedSeats = requests.Count(x => x.ID_softver == s.ID_softver),
                             AvailableSeats = s.Ukupno_mjesta - requests.Count(x => x.ID_softver == s.ID_softver)
                         }).AsQueryable();

            if (from.HasValue)
                query = query.Where(x => x.Date >= from.Value);
            if (to.HasValue)
                query = query.Where(x => x.Date <= to.Value);

            return query.ToList();
        }
    }
}