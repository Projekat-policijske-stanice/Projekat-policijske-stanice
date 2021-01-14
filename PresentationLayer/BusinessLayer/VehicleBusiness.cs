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
    public class VehicleBusiness : IVehicleBusiness
    {

        private readonly IVehicleRepository vehicleRepository;

        public VehicleBusiness(IVehicleRepository _vehicleRepository)
        {
            this.vehicleRepository = _vehicleRepository;
        }

        public List<Vehicle> GetAllVehicles()
        {
            return this.vehicleRepository.GetAllVehicles();
        }
        

        public List<Vehicle> GetAvailableVehicles() 
        {
            return this.vehicleRepository.GetAllVehicles().Where(v => v.Condition == "U garazi").ToList();
        }

        public bool InsertVehicle(Vehicle v)
        {
            if (this.vehicleRepository.InsertVehicle(v) > 0) 
            {
                return true;
            }
            return false;
        }

        public bool UpdateVehicle(Vehicle v)
        {
            if (this.vehicleRepository.UpdateVehicle(v) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteVehicle(int Id)
        {
            if (this.vehicleRepository.DeleteVehicle(Id) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
