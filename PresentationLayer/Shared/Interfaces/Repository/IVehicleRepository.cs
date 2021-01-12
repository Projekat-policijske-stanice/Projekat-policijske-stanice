using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAllVehicles();
        int InsertVehicle(Vehicle v);
        int UpdateVehicle(Vehicle v);
        int DeleteVehicle(int Id);

    }
}
