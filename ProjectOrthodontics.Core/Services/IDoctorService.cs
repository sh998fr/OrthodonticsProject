using ProjectOrthodontics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrthodontics.Core.Services
{
    public interface IDoctorService
    {
        List<Doctors> GetDoctors();
        void DeleteDoctor(string idD);
        void PutDoctor(Doctors d);
        void PostDoctor(Doctors d);
        Doctors GetDoctorById(string id);
    }
}
