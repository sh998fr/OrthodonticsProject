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
    public class DoctorRepository:IDoctorRepository
    {
        private readonly DataContext _context;
        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
        public List<Doctors> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }
        public Doctors GetDoctorById(string id)
        {
            return _context.Doctors.First(d=>d.ID == id);
        }

        public void Post( Doctors d)
        {
           
            _context.Doctors.Add(d);
        }


        public void Put(string id, Doctors d)
        {
           
            var doctor = _context.Doctors.ToList().Find(item => item.ID == id);
           
            int i = _context.Doctors.ToList().IndexOf(doctor);
            _context.Doctors.ToList().RemoveAt(i);
            _context.Doctors.ToList().Insert(i, d);
        }

       
        public void Delete(string id)
        {
           
            var doctor = _context.Doctors.ToList().Find(item => item.ID == id);
           
            int i = _context.Doctors.ToList().IndexOf(doctor);
            _context.Doctors.ToList().RemoveAt(i);
        }
    }
}
