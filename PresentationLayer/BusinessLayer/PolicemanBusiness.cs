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
    public class PolicemanBusiness : IPolicemanBusiness
    {
        private readonly IPolicemanRepository policemanRepository;

        public PolicemanBusiness(IPolicemanRepository _policemanRepository)
        {
            this.policemanRepository = _policemanRepository;
        }

        public List<Policeman> GetAllPolicemen()
        {
            return this.policemanRepository.GetAllPolicemen();
        }

        public List<Policeman> GetPolicemenAtWork()
        {
            return this.policemanRepository.GetAllPolicemen().Where(p => p.Status == "Prisutan").ToList();
        }


        public bool InsertPoliceman(Policeman p)
        {
            if (this.policemanRepository.InsertPoliceman(p) > 0) 
            {
                return true;
            }
            return false;
        }

        public bool UpdatePoliceman(Policeman p)
        {
            if (this.policemanRepository.UpdatePoliceman(p) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeletePoliceman(int Id)
        {
            if (this.policemanRepository.DeletePoliceman(Id) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
