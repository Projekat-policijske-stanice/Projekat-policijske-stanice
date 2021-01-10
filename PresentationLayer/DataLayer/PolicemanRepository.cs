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
    public class PolicemanRepository
    {
        public List<Policeman> GetAllPolicemen()
        {
            List<Policeman> policemen = new List<Policeman>();
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Policemen;";
                sqlCommand.Connection = conn;

                conn.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Policeman p = new Policeman();
                    p.Id = sqlDataReader.GetInt32(0);
                    p.Name = sqlDataReader.GetString(1);
                    p.Surname = sqlDataReader.GetString(2);
                    p.JMBG = sqlDataReader.GetString(3);
                    p.Shift = sqlDataReader.GetString(4);
                    p.Status = sqlDataReader.GetString(5);
                    p.Gender = sqlDataReader.GetString(6);

                    policemen.Add(p);
                }
                return policemen;
            }
        }

        public int InsertPoliceman(Policeman p)
        {
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                
                sqlCommand.CommandText = string.Format("INSERT INTO Policemen VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", p.Name, p.Surname, p.JMBG, p.Shift, p.Status, p.Gender);
                sqlCommand.Connection = conn;

                conn.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }

        public int UpdatePoliceman(Policeman p)
        {
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = string.Format("UPDATE Policemen SET Name = '{0}', Surname = '{1}',  JMBG = '{2}', Shift = '{3}', Status = '{4}', Gender = '{5}' WHERE Id = '{6}';", p.Name, p.Surname, p.JMBG, p.Shift, p.Status, p.Gender, p.Id);
                sqlCommand.Connection = conn;

                conn.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
      
        public int DeletePoliceman(int id)
        {
            using (SqlConnection conn = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = string.Format("DELETE FROM Policemen WHERE Id = '{0}';", id);
                sqlCommand.Connection = conn;

                conn.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

    

