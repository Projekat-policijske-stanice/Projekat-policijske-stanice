using DataLayer.Models;
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
    public class OffenseRepository
    {
        public List<Offense> GetAllOffenses()
        {
            List<Offense> offenses = new List<Offense>();
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Offenses;";
                sqlCommand.Connection = conn;

                conn.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                
                while (sqlDataReader.Read())
                {
                    Offense o = new Offense();
                    o.Date = sqlDataReader.GetDateTime(0);
                    o.VehicleId = sqlDataReader.GetInt32(1);
                    o.PolicemanId = sqlDataReader.GetInt32(2);
                    offenses.Add(o);
                }
                return offenses;
            }
        }
        
        public int InsertOffense(Offense o)
        {
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = string.Format("INSERT INTO Offenses VALUES ('{0}','{1}','{2}');", o.Date, o.VehicleId, o.PolicemanId);
                sqlCommand.Connection = conn;

                conn.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int DeleteOffense(Offense o)
        {
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = string.Format("DELETE FROM Offenses WHERE Date = '{0}' AND VehicleId = '{1}' AND PolicemanId = '{2}';", o.Date,o.VehicleId, o.PolicemanId);
                sqlCommand.Connection = conn;

                conn.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
