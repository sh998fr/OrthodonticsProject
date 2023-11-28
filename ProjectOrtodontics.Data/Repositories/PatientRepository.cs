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
    public class PatientRepository:IPatientRepository
    {
        private readonly DataContext _context;
        public PatientRepository(DataContext context) { _context = context; }
        public List<Patientcs> GetAllPatientcs()
        {
            return _context.Patientcs;
        }
        public Patientcs GetPatientcsById(string id)
        {
            return _context.Patientcs.First(p => p.IdP == id);
        }
      
        public void Post( Patientcs p)
        {
           
            _context.Patientcs.Add(p);
        }

        
        public void Put(string id, Patientcs p)
        {
           
            Patientcs patientcs1 = _context.Patientcs.Find(item => item.IdP == id);
           
            int i = _context.Patientcs.IndexOf(patientcs1);
            _context.Patientcs.RemoveAt(i);
            _context.Patientcs.Insert(i, p);
        }

       
        public void Delete(string id)
        {
          
            Patientcs p = _context.Patientcs.Find(item => item.IdP == id);
           
            int i = _context.Patientcs.IndexOf(p);
            _context.Patientcs.RemoveAt(i);
        }
    }
}
