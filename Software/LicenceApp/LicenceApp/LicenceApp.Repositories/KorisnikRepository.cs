using System.Collections.Generic;
using DBLayer;
using System.Data.SqlClient;
using LicenceApp.Models;

namespace LicenceApp.Repositories
{
    public class KorisnikRepository
    {
        public List<Korisnik> DohvatiSve()
        {
            List<Korisnik> korisnici = new List<Korisnik>();

            DB.OpenConnection();
            string query = "SELECT ID_korisnik, Ime, Prezime, Email, LozinkaHash, Uloga FROM Korisnik";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                Korisnik korisnik = new Korisnik
                {
                    ID_korisnik = (int)reader["ID_korisnik"],
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString(),
                    Email = reader["Email"].ToString(),
                    LozinkaHash = reader["LozinkaHash"].ToString(),
                    Uloga = reader["Uloga"].ToString()
                };
                korisnici.Add(korisnik);
            }
            DB.CloseConnection();
            return korisnici;
        }

        public Korisnik Prijava(string email, string lozinka)
        {
            DB.OpenConnection();

            string query = $"SELECT ID_korisnik, Ime, Prezime, Email, LozinkaHash, Uloga FROM Korisnik WHERE Email = '{email}' AND LozinkaHash = '{lozinka}'";
            SqlDataReader reader = DB.GetDataReader(query);

            Korisnik korisnik = null;
            if (reader.Read())
            {
                korisnik = new Korisnik
                {
                    ID_korisnik = (int)reader["ID_korisnik"],
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString(),
                    Email = reader["Email"].ToString(),
                    LozinkaHash = reader["LozinkaHash"].ToString(),
                    Uloga = reader["Uloga"].ToString()
                };
            }

            DB.CloseConnection();
            return korisnik;
        }

        public bool Dodaj(Korisnik korisnik)
        {
            DB.OpenConnection();
            string query = $"INSERT INTO Korisnik (Ime, Prezime, Email, LozinkaHash, Uloga) VALUES ('{korisnik.Ime}', '{korisnik.Prezime}', '{korisnik.Email}', '{korisnik.LozinkaHash}', '{korisnik.Uloga}')";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Uredi(Korisnik korisnik)
        {
            DB.OpenConnection();
            string query = $"UPDATE Korisnik SET Ime = '{korisnik.Ime}', Prezime = '{korisnik.Prezime}', Email = '{korisnik.Email}', LozinkaHash = '{korisnik.LozinkaHash}', Uloga = '{korisnik.Uloga}' WHERE ID_korisnik = {korisnik.ID_korisnik}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Obrisi(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Korisnik WHERE ID_korisnik = {id}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }
    }
}
