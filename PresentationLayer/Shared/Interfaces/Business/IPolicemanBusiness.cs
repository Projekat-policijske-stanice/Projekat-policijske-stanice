using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IPolicemanBusiness
    {
        List<Policeman> GetAllPolicemen();
        List<Policeman> GetPolicemenAtWork();
        bool InsertPoliceman(Policeman p);
        bool UpdatePoliceman(Policeman p);
        bool DeletePoliceman(int Id);
    }
}
