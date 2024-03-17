using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string? Firstname { get; set;}
        public string? Lastname { get; set; }
        public bool IsMale { get; set; }
        public DateTime DateofBirth { get; set; }

        public List<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();

        public override string ToString()
        {
            return "";
        }
    }
}
