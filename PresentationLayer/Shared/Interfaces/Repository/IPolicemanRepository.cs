using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IPolicemanRepository
    {
        List<Policeman> GetAllPolicemen();
        int InsertPoliceman(Policeman p);
        int UpdatePoliceman(Policeman p);
        int DeletePoliceman(int id);
    }
}
