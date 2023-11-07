using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private static List< Doctors> _doctors= new List< Doctors>();
        // GET: api/<DoctorsController>
        [HttpGet]
        public IEnumerable<Doctors> Get()
        {
            return _doctors;
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public Doctors Get(string id)
        {
            return _doctors.Find(item=>item.IdD==id);
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public void Post([FromBody] Doctors d)
        {
            _doctors.Add(d);
        }

        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Doctors d)
        {
            var doctor = _doctors.Find(item=>item.IdD==id);
           int i= _doctors.IndexOf(doctor);
            _doctors.RemoveAt(i);
            _doctors.Insert(i, d);
        }

        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var doctor = _doctors.Find(item => item.IdD == id);
            int i = _doctors.IndexOf(doctor);
            _doctors.RemoveAt(i);
        }
    }
}
