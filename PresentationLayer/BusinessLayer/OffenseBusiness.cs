using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OffenseBusiness
    {
        private readonly OffenseRepository offenseRepository;

        public OffenseBusiness()
        {
            this.offenseRepository = new OffenseRepository();
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
