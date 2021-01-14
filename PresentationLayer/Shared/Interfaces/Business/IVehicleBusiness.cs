using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IVehicleBusiness
    {
        List<Vehicle> GetAllVehicles();
        List<Vehicle> GetAvailableVehicles();
        bool InsertVehicle(Vehicle v);
        bool UpdateVehicle(Vehicle v);
        bool DeleteVehicle(int Id);
    }
}
