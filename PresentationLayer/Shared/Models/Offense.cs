using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Offense
    {
        public DateTime Date { get; set; }
        public int VehicleId { get; set; }
        public int PolicemanId { get; set; }
    }
}
