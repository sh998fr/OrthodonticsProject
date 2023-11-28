using ProjectOrthodontics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrthodontics.Core.Repositories
{
    public interface IDoctorRepository
    {
        List<Doctors> GetAllDoctors();
        Doctors GetDoctorById(string id);
        void Post(Doctors d);
        void Put(string id, Doctors d);
        void Delete(string id);
    }
}
