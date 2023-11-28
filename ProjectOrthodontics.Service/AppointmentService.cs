using ProjectOrthodontics.Core.Entities;
using ProjectOrthodontics.Core.Repositories;
using ProjectOrthodontics.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrthodontics.Service
{
    public class AppointmentService:IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
           _appointmentRepository = appointmentRepository;
        }
        public List<Appointment> GetAppointment()
        {
            //TODO business logic
            return _appointmentRepository.GetAllAppointments();
        }
        public Appointment GetAppointmentById(int code)
        {
            return _appointmentRepository.GetAppointmentById(code);
        }
        public void PostAppointment(Appointment a)
        {
            _appointmentRepository.Post(a);
        }
        public void PutAppointment(Appointment a)
        {
            _appointmentRepository.Put(a.CodeA,a);
        }
        public void DeleteAppointment(int code)
        {
            _appointmentRepository.Delete(code);
        }
    }
}
