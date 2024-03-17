using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class HospitalDBContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Vaccination> Vaccations { get; set; }
        public DbSet<Vacine> Vacines { get; set; }


        public HospitalDBContext(DbContextOptions<HospitalDBContext> options) : base(options)
        {

        }

        public HospitalDBContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            string conStr = @"server=(LocalDB)\mssqllocaldb;attachdbfilename=C:\Users\HoeKla\source\repos\UebungTest\DataLayerLib\HosDB.mdf; database=HosDBGrpA;integrated security=True;MultipleActiveResultSets=True;";

            Console.WriteLine($"Using ConnStr={conStr}");
            optionsBuilder.UseSqlServer(conStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}

