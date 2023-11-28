using ProjectOrthodontics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrthodontics.Core.Services
{
    public interface IAppointmentService
    {
        void DeleteAppointment(int code);
        void PutAppointment(Appointment a);
        void PostAppointment(Appointment a);
        Appointment GetAppointmentById(int code);
        List<Appointment> GetAppointment();
    }
}
