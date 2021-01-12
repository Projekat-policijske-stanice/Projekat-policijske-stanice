using DataLayer.Models;
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
    public class PolicemanRepository : IPolicemanRepository
    {
        public List<Policeman> GetAllPolicemen()
        {
            List<Policeman> policemen = new List<Policeman>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Policemen;");

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
            DBConnection.CloseConnection();
            return policemen;
        }

        public int InsertPoliceman(Policeman p)
        {         
            var result = DBConnection.EditData(string.Format("INSERT INTO Policemen VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", p.Name, p.Surname, p.JMBG, p.Shift, p.Status, p.Gender));
            DBConnection.CloseConnection();
            return result;
        }

        public int UpdatePoliceman(Policeman p)
        {
            var result = DBConnection.EditData(string.Format("UPDATE Policemen SET Name = '{0}', Surname = '{1}',  JMBG = '{2}', Shift = '{3}', Status = '{4}', Gender = '{5}' WHERE Id = '{6}';", p.Name, p.Surname, p.JMBG, p.Shift, p.Status, p.Gender, p.Id));
            DBConnection.CloseConnection();
            return result;
        }

        public int DeletePoliceman(int id)
        { 
            var result = DBConnection.EditData(string.Format("DELETE FROM Policemen WHERE Id = '{0}';", id));
            DBConnection.CloseConnection();
            return result;
        }
    }
}



