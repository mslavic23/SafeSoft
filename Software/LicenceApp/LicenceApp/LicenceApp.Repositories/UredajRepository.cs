using System.Collections.Generic;
using DBLayer;
using System.Data.SqlClient;
using LicenceApp.Models;

namespace LicenceApp.Repositories
{
    public class UredajRepository
    {
        public List<Uredaj> DohvatiSve()
        {
            List<Uredaj> uredaji = new List<Uredaj>();

            DB.OpenConnection();
            string query = "SELECT ID_uredaj, Naziv_racunala, Lokacija, Tip_uredaja FROM Uredaj";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                Uredaj uredaj = new Uredaj
                {
                    ID_uredaj = (int)reader["ID_uredaj"],
                    Naziv_racunala = reader["Naziv_racunala"].ToString(),
                    Lokacija = reader["Lokacija"].ToString(),
                    Tip_uredaja = reader["Tip_uredaja"].ToString()
                };
                uredaji.Add(uredaj);
            }
            DB.CloseConnection();
            return uredaji;
        }

        public bool Dodaj(Uredaj uredaj)
        {
            DB.OpenConnection();
            string query = $"INSERT INTO Uredaj (Naziv_racunala, Lokacija, Tip_uredaja) VALUES ('{uredaj.Naziv_racunala}', '{uredaj.Lokacija}', '{uredaj.Tip_uredaja}')";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Uredi(Uredaj uredaj)
        {
            DB.OpenConnection();
            string query = $"UPDATE Uredaj SET Naziv_racunala = '{uredaj.Naziv_racunala}', Lokacija = '{uredaj.Lokacija}', Tip_uredaja = '{uredaj.Tip_uredaja}' WHERE ID_uredaj = {uredaj.ID_uredaj}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Obrisi(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Uredaj WHERE ID_uredaj = {id}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }
    }
}
