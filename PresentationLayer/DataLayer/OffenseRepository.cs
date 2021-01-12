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
    public class OffenseRepository : IOffenseRepository
    {
        public List<Offense> GetAllOffenses()
        {
            List<Offense> offenses = new List<Offense>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Offenses;");


            while (sqlDataReader.Read())
            {
                Offense o = new Offense();
                o.Date = sqlDataReader.GetDateTime(0);
                o.VehicleId = sqlDataReader.GetInt32(1);
                o.PolicemanId = sqlDataReader.GetInt32(2);
                offenses.Add(o);
            }
            DBConnection.CloseConnection();
            return offenses;
        }
        public int InsertOffense(Offense o)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Offenses VALUES ('{0}','{1}','{2}');", o.Date, o.VehicleId, o.PolicemanId));
            DBConnection.CloseConnection();
            return result;
        }

        public int DeleteOffense(Offense o)
        {

            var result = DBConnection.EditData(string.Format("DELETE FROM Offenses WHERE Date = '{0}' AND VehicleId = '{1}' AND PolicemanId = '{2}';", o.Date, o.VehicleId, o.PolicemanId));
            DBConnection.CloseConnection();
            return result;
        }
    }
}
