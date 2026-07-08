using System.Collections.Generic;
using DBLayer;
using System.Data.SqlClient;
using LicenceApp.Models;
using LicenceApp.Helpers;

namespace LicenceApp.Repositories
{
    public class UserRepository
    {
        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            DB.OpenConnection();
            string query = "SELECT ID_korisnik, Ime, Prezime, Email, LozinkaHash, Uloga FROM Korisnik";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                User user = new User
                {
                    ID_korisnik = (int)reader["ID_korisnik"],
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString(),
                    Email = reader["Email"].ToString(),
                    LozinkaHash = reader["LozinkaHash"].ToString(),
                    Uloga = reader["Uloga"].ToString()
                };
                users.Add(user);
            }
            DB.CloseConnection();
            return users;
        }

        public User Login(string email, string password)
        {
            DB.OpenConnection();

            string hash = HashHelper.HashPassword(password);
            string query = $"SELECT ID_korisnik, Ime, Prezime, Email, LozinkaHash, Uloga FROM Korisnik WHERE Email = '{email}' AND LozinkaHash = '{hash}'";
            SqlDataReader reader = DB.GetDataReader(query);

            User user = null;
            if (reader.Read())
            {
                user = new User
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
            return user;
        }

        public bool Add(User user)
        {
            DB.OpenConnection();
            string hash = HashHelper.HashPassword(user.LozinkaHash);
            string query = $"INSERT INTO Korisnik (Ime, Prezime, Email, LozinkaHash, Uloga) VALUES ('{user.Ime}', '{user.Prezime}', '{user.Email}', '{hash}', '{user.Uloga}')";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Update(User user)
        {
            DB.OpenConnection();

            string query;
            if (string.IsNullOrEmpty(user.LozinkaHash))
            {
                query = $"UPDATE Korisnik SET Ime = '{user.Ime}', Prezime = '{user.Prezime}', Email = '{user.Email}', Uloga = '{user.Uloga}' WHERE ID_korisnik = {user.ID_korisnik}";
            }
            else
            {
                string hash = HashHelper.HashPassword(user.LozinkaHash);
                query = $"UPDATE Korisnik SET Ime = '{user.Ime}', Prezime = '{user.Prezime}', Email = '{user.Email}', LozinkaHash = '{hash}', Uloga = '{user.Uloga}' WHERE ID_korisnik = {user.ID_korisnik}";
            }

            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Delete(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Korisnik WHERE ID_korisnik = {id}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }
    }
}