using Shared;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Vehicles;");

            while (sqlDataReader.Read())
            {
                Vehicle v = new Vehicle();
                v.Id = sqlDataReader.GetInt32(0);
                v.Name = sqlDataReader.GetString(1);
                v.Type = sqlDataReader.GetString(2);
                v.Consumption = sqlDataReader.GetDecimal(3);
                v.Correctness = sqlDataReader.GetString(4);
                v.Condition = sqlDataReader.GetString(5);

                vehicles.Add(v);
            }
            DBConnection.CloseConnection();
            return vehicles;
        }
        public int InsertVehicle(Vehicle v)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Vehicles VALUES ('{0}','{1}','{2}','{3}','{4}');", v.Name, v.Type, v.Consumption, v.Correctness, v.Condition));
            DBConnection.CloseConnection();
            return result;
        }
        public int UpdateVehicle(Vehicle v)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Vehicles SET Name = '{0}', Type = '{1}', Consumption = '{2}', Correctness = '{3}', Condition = '{4}' WHERE Id = '{5}';", v.Name, v.Type, v.Consumption, v.Correctness, v.Condition, v.Id));
            DBConnection.CloseConnection();
            return result;
        }

        public int DeleteVehicle(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Vehicles WHERE Id = '{0}';", Id));
            DBConnection.CloseConnection();
            return result;
        }
    }   
}

