using System;
using System.Collections.Generic;
using DBLayer;
using System.Data.SqlClient;
using LicenceApp.Models;

namespace LicenceApp.Repositories
{
    public class ZahtjevRepository
    {
        public List<Zahtjev> DohvatiSve()
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            DB.OpenConnection();
            string query = "SELECT ID_zahtjev, ID_korisnik, ID_softver, ID_uredaj, Razlog_koristenja, Datum_podnosenja FROM Zahtjev";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                Zahtjev zahtjev = new Zahtjev
                {
                    ID_zahtjev = (int)reader["ID_zahtjev"],
                    ID_korisnik = (int)reader["ID_korisnik"],
                    ID_softver = (int)reader["ID_softver"],
                    ID_uredaj = (int)reader["ID_uredaj"],
                    Razlog_koristenja = reader["Razlog_koristenja"].ToString(),
                    Datum_podnosenja = (DateTime)reader["Datum_podnosenja"]
                };
                zahtjevi.Add(zahtjev);
            }
            DB.CloseConnection();
            return zahtjevi;
        }

        public List<Zahtjev> DohvatiZaKorisnika(int idKorisnik)
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            DB.OpenConnection();
            string query = $"SELECT ID_zahtjev, ID_korisnik, ID_softver, ID_uredaj, Razlog_koristenja, Datum_podnosenja FROM Zahtjev WHERE ID_korisnik = {idKorisnik}";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                Zahtjev zahtjev = new Zahtjev
                {
                    ID_zahtjev = (int)reader["ID_zahtjev"],
                    ID_korisnik = (int)reader["ID_korisnik"],
                    ID_softver = (int)reader["ID_softver"],
                    ID_uredaj = (int)reader["ID_uredaj"],
                    Razlog_koristenja = reader["Razlog_koristenja"].ToString(),
                    Datum_podnosenja = (DateTime)reader["Datum_podnosenja"]
                };
                zahtjevi.Add(zahtjev);
            }
            DB.CloseConnection();
            return zahtjevi;
        }

        public bool ImaLicenci(int idSoftver)
        {
            DB.OpenConnection();

            string queryUkupno = $"SELECT Ukupno_mjesta FROM Softver WHERE ID_softver = {idSoftver}";
            object rezultatUkupno = DB.GetScalar(queryUkupno);

            if (rezultatUkupno == null || rezultatUkupno == DBNull.Value)
            {
                DB.CloseConnection();
                return false;
            }

            int ukupnoMjesta = (int)rezultatUkupno;

            string queryZauzeto = $"SELECT COUNT(*) FROM Zahtjev WHERE ID_softver = {idSoftver}";
            int zauzeto = (int)DB.GetScalar(queryZauzeto);

            DB.CloseConnection();
            return zauzeto < ukupnoMjesta;
        }

        public bool Dodaj(Zahtjev zahtjev)
        {
            DB.OpenConnection();
            string datum = zahtjev.Datum_podnosenja.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"INSERT INTO Zahtjev (ID_korisnik, ID_softver, ID_uredaj, Razlog_koristenja, Datum_podnosenja) VALUES ({zahtjev.ID_korisnik}, {zahtjev.ID_softver}, {zahtjev.ID_uredaj}, '{zahtjev.Razlog_koristenja}', '{datum}')";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Uredi(Zahtjev zahtjev)
        {
            DB.OpenConnection();
            string datum = zahtjev.Datum_podnosenja.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"UPDATE Zahtjev SET ID_korisnik = {zahtjev.ID_korisnik}, ID_softver = {zahtjev.ID_softver}, ID_uredaj = {zahtjev.ID_uredaj}, Razlog_koristenja = '{zahtjev.Razlog_koristenja}', Datum_podnosenja = '{datum}' WHERE ID_zahtjev = {zahtjev.ID_zahtjev}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Obrisi(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Zahtjev WHERE ID_zahtjev = {id}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }
    }
}
