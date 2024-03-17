using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class Vaccination
    {
        public int VaccinationID { get; set; }
        public DateTime VacDateTime { get; set; }
        public string? AdverseEffects { get; set; }
        public int DoctorDoctorID { get; set; }
        public Doctor? VacDoctor_Doctor { get; set; }
        public int PatientPatientID { get; set; }
        public Patient? VacPatient_Patient { get; set; }
        public int VacineVacineID { get; set; }
        public Vaccination? VacVacine_Vacine { get; set; }

        //public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        //public List<Patient> Patients { get; set; } = new List<Patient>();
        //public List<Vacine> Vacines { get; set; } = new List<Vacine>();
    }
}
