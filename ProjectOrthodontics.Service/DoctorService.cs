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
    public class DoctorService:IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public List<Doctors> GetDoctors()
        {
            //TODO business logic
            return _doctorRepository.GetAllDoctors();
        }
        public Doctors GetDoctorById(string id)
        {
            return _doctorRepository.GetDoctorById(id);
        }
        public void PostDoctor(Doctors d)
        {
            _doctorRepository.Post(d);
        }
        public void PutDoctor(Doctors d)
        {
            _doctorRepository.Put(d.IdD, d);
        }
        public void DeleteDoctor(string idD)
        {
            _doctorRepository.Delete(idD);
        }
    }
}
