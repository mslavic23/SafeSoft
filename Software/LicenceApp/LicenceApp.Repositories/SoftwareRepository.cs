using System.Collections.Generic;
using DBLayer;
using System.Data.SqlClient;
using LicenceApp.Models;
using LicenceApp.Helpers;

namespace LicenceApp.Repositories
{
    public class SoftwareRepository
    {
        public List<Software> GetAll()
        {
            List<Software> softveri = new List<Software>();

            DB.OpenConnection();
            string query = "SELECT ID_softver, Naziv, Verzija, Tip_licence, Ukupno_mjesta FROM Softver";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                Software softver = new Software
                {
                    ID_softver = (int)reader["ID_softver"],
                    Naziv = reader["Naziv"].ToString(),
                    Verzija = reader["Verzija"].ToString(),
                    Tip_licence = reader["Tip_licence"].ToString(),
                    Ukupno_mjesta = (int)reader["Ukupno_mjesta"]
                };
                softveri.Add(softver);
            }
            DB.CloseConnection();
            return softveri;
        }

        public bool Add(Software softver)
        {
            DB.OpenConnection();
            string query = $"INSERT INTO Softver (Naziv, Verzija, Tip_licence, Ukupno_mjesta) VALUES ('{softver.Naziv}', '{softver.Verzija}', '{softver.Tip_licence}', {softver.Ukupno_mjesta})";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Update(Software softver)
        {
            DB.OpenConnection();
            string query = $"UPDATE Softver SET Naziv = '{softver.Naziv}', Verzija = '{softver.Verzija}', Tip_licence = '{softver.Tip_licence}', Ukupno_mjesta = {softver.Ukupno_mjesta} WHERE ID_softver = {softver.ID_softver}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Delete(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Softver WHERE ID_softver = {id}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }
    }
}