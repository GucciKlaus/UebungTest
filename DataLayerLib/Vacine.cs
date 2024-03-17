using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class Vacine
    {
        public int VacineID { get; set; }
        public string Producer { get; set; }
        public int ChargeID { get; set; }

        public List<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
        public override string ToString()
        {
            return Producer;
        }
    }
}
