using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IOffenseRepository
    {
        List<Offense> GetAllOffenses();
        int InsertOffense(Offense o);
        int DeleteOffense(Offense o);
    }
}
