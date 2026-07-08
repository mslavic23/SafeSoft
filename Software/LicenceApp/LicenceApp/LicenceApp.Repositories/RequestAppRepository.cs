using System;
using System.Collections.Generic;
using DBLayer;
using System.Data.SqlClient;
using LicenceApp.Models;

namespace LicenceApp.Repositories
{
    public class RequestAppRepository
    {
        public List<RequestApp> GetAll()
        {
            List<RequestApp> requests = new List<RequestApp>();

            DB.OpenConnection();
            string query = "SELECT ID_zahtjev, ID_korisnik, ID_softver, ID_uredaj, Razlog_koristenja, Datum_podnosenja FROM Zahtjev";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                RequestApp request = new RequestApp
                {
                    ID_zahtjev = (int)reader["ID_zahtjev"],
                    ID_korisnik = (int)reader["ID_korisnik"],
                    ID_softver = (int)reader["ID_softver"],
                    ID_uredaj = (int)reader["ID_uredaj"],
                    Razlog_koristenja = reader["Razlog_koristenja"].ToString(),
                    Datum_podnosenja = (DateTime)reader["Datum_podnosenja"]
                };
                requests.Add(request);
            }
            DB.CloseConnection();
            return requests;
        }

        public List<RequestApp> GetByUser(int userId)
        {
            List<RequestApp> requests = new List<RequestApp>();

            DB.OpenConnection();
            string query = $"SELECT ID_zahtjev, ID_korisnik, ID_softver, ID_uredaj, Razlog_koristenja, Datum_podnosenja FROM Zahtjev WHERE ID_korisnik = {userId}";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                RequestApp request = new RequestApp
                {
                    ID_zahtjev = (int)reader["ID_zahtjev"],
                    ID_korisnik = (int)reader["ID_korisnik"],
                    ID_softver = (int)reader["ID_softver"],
                    ID_uredaj = (int)reader["ID_uredaj"],
                    Razlog_koristenja = reader["Razlog_koristenja"].ToString(),
                    Datum_podnosenja = (DateTime)reader["Datum_podnosenja"]
                };
                requests.Add(request);
            }
            DB.CloseConnection();
            return requests;
        }

        public bool HasAvailableSeats(int softwareId)
        {
            DB.OpenConnection();

            string totalQuery = $"SELECT Ukupno_mjesta FROM Softver WHERE ID_softver = {softwareId}";
            object totalResult = DB.GetScalar(totalQuery);

            if (totalResult == null || totalResult == DBNull.Value)
            {
                DB.CloseConnection();
                return false;
            }

            int totalSeats = (int)totalResult;

            string occupiedQuery = $"SELECT COUNT(*) FROM Zahtjev WHERE ID_softver = {softwareId}";
            int occupiedSeats = (int)DB.GetScalar(occupiedQuery);

            DB.CloseConnection();
            return occupiedSeats < totalSeats;
        }

        public bool Add(RequestApp request)
        {
            DB.OpenConnection();
            string date = request.Datum_podnosenja.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"INSERT INTO Zahtjev (ID_korisnik, ID_softver, ID_uredaj, Razlog_koristenja, Datum_podnosenja) VALUES ({request.ID_korisnik}, {request.ID_softver}, {request.ID_uredaj}, '{request.Razlog_koristenja}', '{date}')";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Update(RequestApp request)
        {
            DB.OpenConnection();
            string date = request.Datum_podnosenja.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"UPDATE Zahtjev SET ID_korisnik = {request.ID_korisnik}, ID_softver = {request.ID_softver}, ID_uredaj = {request.ID_uredaj}, Razlog_koristenja = '{request.Razlog_koristenja}', Datum_podnosenja = '{date}' WHERE ID_zahtjev = {request.ID_zahtjev}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Delete(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Zahtjev WHERE ID_zahtjev = {id}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }
    }
}