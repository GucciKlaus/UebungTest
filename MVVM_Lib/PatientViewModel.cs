using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lib
{
    public class PatientViewModel
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool IsMale { get; set; }
        public DateTime Geburtstag { get; set; }
        public int AnzahlImpfungen { get; set; }
    }
}
