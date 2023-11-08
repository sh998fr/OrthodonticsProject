using ProjectOrthodontics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOrthodontics
{
    public class DataContext
    {
        public List<Appointment> Appointments { get; set; }
        public  List<Doctors> Doctors { get; set; }
        public List<Patientcs> Patientcs { get; set; }
        public DataContext()
        {
            Appointments = new List<Appointment>();
            Doctors = new List<Doctors>();
            Patientcs = new List<Patientcs>();
        }
    }
}
