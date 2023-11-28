using ProjectOrthodontics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrthodontics.Core.Repositories
{
    public interface IPatientRepository
    {
        List<Patientcs> GetAllPatientcs();
        Patientcs GetPatientcsById(string id);
        void Post(Patientcs p);
        void Put(string id, Patientcs p);
        void Delete(string id);
    }
}
