using DataLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OffenseBusiness : IOffenseBusiness
    {
        private readonly IOffenseRepository offenseRepository;

        public OffenseBusiness(IOffenseRepository _offenseRepository)
        {
            this.offenseRepository = _offenseRepository;
        }
        public List<Offense> GetAllOffenses()
        {
            return this.offenseRepository.GetAllOffenses();
        }
        public bool InsertOffense(Offense o)
        {
            if (this.offenseRepository.InsertOffense(o) > 0) 
            {
                return true;
            }
            return false;
        }
        public bool DeleteOffense(Offense o)
        {
            if (this.offenseRepository.DeleteOffense(o) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
