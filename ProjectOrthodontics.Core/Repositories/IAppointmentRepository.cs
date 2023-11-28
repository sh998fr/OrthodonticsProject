using ProjectOrthodontics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrthodontics.Core.Repositories
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAllAppointments();
        Appointment GetAppointmentById(int code);
        void Post(Appointment ap);
        void Put(int id, Appointment ap);
        void Delete(int id);
    }
}
