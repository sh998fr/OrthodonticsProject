using ProjectOrthodontics;
using ProjectOrthodontics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class DataContextFake : IDataContext
    {
        public List<Appointment> Appointments { get ; set; }
        public List<Doctors> Doctors { get ; set ; }
        public List<Patientcs> Patientcs { get ; set ; }
        public DataContextFake()
        {
            Appointments = new List<Appointment>();
            Appointments.Add(new Appointment { CodeA=1,AppointmentDate=DateTime.Now,AppointmentName="scan mouse",AppointmentStartTime=DateTime.Now,SerialNumber=1,Documenting=2});
            Doctors = new List<Doctors>();
            Doctors.Add(new Doctors { IdD = "123456789", hours = new List<string> { "2-5", "4-7" }, days = new List<string> { "monday", "sunday" }, NameD = "Levi" });
            Patientcs = new List<Patientcs>();
            Patientcs.Add(new Patientcs { IdP = "123456789", Age = 5, Dateofbirth = DateTime.Now, Familyname = "Coen", NameP = "Shimi" });
        }
    }
}
