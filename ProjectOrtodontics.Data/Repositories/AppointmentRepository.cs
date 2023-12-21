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
            return _context.Appointments.ToList();
        }


        public Appointment GetAppointmentById(int code)
        {
            return _context.Appointments.First(a => a.ID == code);
        }


        public void Post(Appointment ap)
        {
            
            _context.Appointments.Add(ap);
           
        }

       
        public void Put(int id, Appointment ap)
        {
            Appointment appointment = _context.Appointments.ToList().Find(item => item.ID == id);
           
            int i = _context.Appointments.ToList().IndexOf(appointment);

            _context.Appointments.ToList().RemoveAt(i);

            _context.Appointments.ToList().Insert(i, ap);
        }

       
        public void Delete(int id)
        {
            Appointment a = _context.Appointments.First(item => item.ID == id);
          
            _context.Appointments.Remove(a);
        }
    }
}




