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
    public class PatientService:IPatientService
    {

        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository; 
        }
        public List<Patientcs> GetAllPatientcs()
        {
            //TODO business logic
            return _patientRepository.GetAllPatientcs();
        }
        public Patientcs GetPatientById(string idP)
        {
            return _patientRepository.GetPatientcsById(idP);
        }
        public void PostPatient(Patientcs p)
        {
            _patientRepository.Post(p);
        }
        public void PutPatient(Patientcs p)
        {
            _patientRepository.Put(p.IdP, p);
        }
        public void DeletePatient(string idP)
        {
            _patientRepository.Delete(idP);
        }
    }
}
