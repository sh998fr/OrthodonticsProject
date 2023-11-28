using ProjectOrthodontics;
using ProjectOrthodontics.Core.Entities;
using ProjectOrthodontics.Core.Repositories;
using ProjectOrthodontics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrtodontics.Data.Repositories
{
    public class AppointmentRepository:IAppointmentRepository
    {

        private readonly DataContext _context;
        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }


        public List<Appointment> GetAllAppointments()
        {
            return _context.Appointments;
        }


        public Appointment GetAppointmentById(int code)
        {
            return _context.Appointments.First(a => a.CodeA == code);
        }


        public void Post(Appointment ap)
        {
            
            _context.Appointments.Add(ap);
           
        }

       
        public void Put(int id, Appointment ap)
        {
            Appointment appointment = _context.Appointments.Find(item => item.CodeA == id);
           
            int i = _context.Appointments.IndexOf(appointment);

            _context.Appointments.RemoveAt(i);

            _context.Appointments.Insert(i, ap);
        }

       
        public void Delete(int id)
        {
            Appointment a = _context.Appointments.First(item => item.CodeA == id);
          
            _context.Appointments.Remove(a);
        }
    }
}




