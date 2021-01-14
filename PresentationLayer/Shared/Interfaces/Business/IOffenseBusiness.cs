using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IOffenseBusiness
    {
        List<Offense> GetAllOffenses();
        bool InsertOffense(Offense o);
        bool DeleteOffense(Offense o);
    }
}
