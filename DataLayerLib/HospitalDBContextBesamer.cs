using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public static class HospitalDBContextBesamer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Patient p1 = new Patient { PatientID = 1,DateofBirth = DateTime.Now, Firstname = "Sepp", Lastname = "Test", IsMale = false};
            Doctor d1 = new Doctor { DoctorID = 1, Firstname = "Bernd", Lastname = "Huber", Title = "Dr." };
            Vacine v1 = new Vacine { ChargeID = 1, Producer = "Pferd", VacineID = 1 };
            Vaccination va1 = new Vaccination {VaccinationID = 1,VacDateTime = DateTime.Now, AdverseEffects="Keine",DoctorDoctorID = 1, PatientPatientID = 1, VacineVacineID = 1};
            Patient p2 = new Patient { PatientID = 2, DateofBirth = DateTime.Now, Firstname = "Sepp2", Lastname = "Test2", IsMale = true };
            Doctor d2 = new Doctor { DoctorID = 2, Firstname = "Bernd2", Lastname = "Huber2", Title = "Dr." };
            Vacine v2 = new Vacine { ChargeID = 2, Producer = "Pferd2", VacineID = 2 };
            Vaccination va2 = new Vaccination { VaccinationID = 2, VacDateTime = DateTime.Now, AdverseEffects = "Keine2", DoctorDoctorID = 2, PatientPatientID = 2, VacineVacineID = 2};
            modelBuilder.Entity<Doctor>().HasData(d1,d2);
            modelBuilder.Entity<Patient>().HasData(p1,p2);
            modelBuilder.Entity<Vaccination>().HasData(va1,va2);
            modelBuilder.Entity<Vacine>().HasData(v1,v2);
        }
    }
}
