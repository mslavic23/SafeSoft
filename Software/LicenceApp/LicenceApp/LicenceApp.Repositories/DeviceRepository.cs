using System.Collections.Generic;
using DBLayer;
using System.Data.SqlClient;
using LicenceApp.Models;

namespace LicenceApp.Repositories
{
    public class DeviceRepository
    {
        public List<Device> GetAll()
        {
            List<Device> devices = new List<Device>();

            DB.OpenConnection();
            string query = "SELECT ID_uredaj, Naziv_racunala, Lokacija, Tip_uredaja FROM Uredaj";
            SqlDataReader reader = DB.GetDataReader(query);

            while (reader.Read())
            {
                Device device = new Device
                {
                    ID_uredaj = (int)reader["ID_uredaj"],
                    Naziv_racunala = reader["Naziv_racunala"].ToString(),
                    Lokacija = reader["Lokacija"].ToString(),
                    Tip_uredaja = reader["Tip_uredaja"].ToString()
                };
                devices.Add(device);
            }
            DB.CloseConnection();
            return devices;
        }

        public bool Add(Device device)
        {
            DB.OpenConnection();
            string query = $"INSERT INTO Uredaj (Naziv_racunala, Lokacija, Tip_uredaja) VALUES ('{device.Naziv_racunala}', '{device.Lokacija}', '{device.Tip_uredaja}')";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Update(Device device)
        {
            DB.OpenConnection();
            string query = $"UPDATE Uredaj SET Naziv_racunala = '{device.Naziv_racunala}', Lokacija = '{device.Lokacija}', Tip_uredaja = '{device.Tip_uredaja}' WHERE ID_uredaj = {device.ID_uredaj}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }

        public bool Delete(int id)
        {
            DB.OpenConnection();
            string query = $"DELETE FROM Uredaj WHERE ID_uredaj = {id}";
            int affectedRows = DB.ExecuteCommand(query);
            DB.CloseConnection();
            return affectedRows > 0;
        }
    }
}