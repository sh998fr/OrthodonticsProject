using ProjectOrthodontics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrthodontics.Core.Services
{
    public interface IPatientService
    {
        void DeletePatient(string idP);
        void PutPatient(Patientcs p);
        void PostPatient(Patientcs p);
        Patientcs GetPatientById(string idP);
        List<Patientcs> GetAllPatientcs();
    }
}
