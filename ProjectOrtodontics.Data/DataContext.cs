using Microsoft.EntityFrameworkCore;
using ProjectOrthodontics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectOrthodontics.Data
{
    public class DataContext: DbContext
    {
        
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patientcs> Patientcs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sshh_db");
        }

        //public DataContext()
        //{
        //    Appointments = new List<Appointment>();
        //    Doctors = new List<Doctors>();
        //    Patientcs = new List<Patientcs>();
        //}

    }
}
