using DataLayerLib;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MVVM_Lib;
using static System.Net.Mime.MediaTypeNames;

namespace UebungTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HospitalDBContext db {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new HospitalDBContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            //int nrDoc = DB.Doctors.Count();
            //Debug.WriteLine(nrDoc);
            this.DataContext = new ViewModel().Init(db);
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            int count = db.Vacines.Count();
            db.Vacines.Add(new Vaccination() { AdverseEffects = "test", VaccinationID = count,
                VacDateTime = datenbepp.DisplayDate, DoctorDoctorID = ((Doctor)cbo2.SelectedItem).DoctorID, PatientPatientID = 
                db.Vaccations.Where(x=>x.VacPatient_Patient == grid.SelectedItem).Select(x=>x.PatientPatientID, VacineVacineID = ((Vacine)cbo.SelectedItem).VacineID)});
        }
        private void EnableButton()
        {
            if(lbl1 != null && lbl2 != null && datenbepp.GetValue != null && grid.SelectedItem!= null)
            {
                addBtn.IsEnabled = true;
            }
            else
            {
                addBtn.IsEnabled=false;
            }
        }

        private void cbo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableButton();
        }
    }
}