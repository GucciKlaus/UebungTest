using DataLayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Lib
{
    public class ViewModel:ObservableObject
    {
        public HospitalDBContext? DB { get; set;}
        public ViewModel Init(HospitalDBContext db)
        {
            DB = db;
            vaccines = DB.Vacines.OrderBy(x=>x.Producer).ToList();
            vaccines.Add(new Vacine { Producer = "alle Impfstoffe" ,VacineID=99});
            doctors = DB.Doctors.OrderBy(x=>x.Lastname).ToList();
            list = DB.Patients.Select(x=>new PatientViewModel {firstname = x.Firstname,lastname=x.Lastname,IsMale=x.IsMale,Geburtstag = x.DateofBirth,AnzahlImpfungen = x.Vaccinations.Count()}).ToList();
            return this;
        }

        private List<Vacine> vaccines;

        public List<Vacine> Vaccines
        {
            get { return vaccines; }
            set { vaccines = value;
                RaisePropertyChangedEvent(nameof(vaccines));
            }
        }

        private List<Doctor> doctors;

        public List<Doctor> Doctors
        {
            get { return doctors; }
            set
            {
                doctors = value;
                RaisePropertyChangedEvent(nameof(doctors));
            }
        }

        private List<PatientViewModel> list;

        public List<PatientViewModel> List
        {
            get { return list; }
            set { list = value; }
        }

        private Vacine selectedVacine;

        public Vacine SelectedVacine
        {
            get { return selectedVacine; }
            set { selectedVacine = value;
                RaisePropertyChangedEvent(nameof(selectedVacine));
            }
        }

        private Doctor selectedDoc;

        public Doctor SelectedDoc
        {
            get { return selectedDoc; }
            set
            {
                selectedDoc = value;
                RaisePropertyChangedEvent(nameof(selectedDoc));
            }
        }




    }
}
