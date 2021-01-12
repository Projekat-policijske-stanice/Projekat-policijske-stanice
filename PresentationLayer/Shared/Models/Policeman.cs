using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
   public class Policeman
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JMBG { get; set; }
        public string Shift { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
    }
}
