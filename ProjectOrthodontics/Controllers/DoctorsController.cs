using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private DataContext _context;
        public DoctorsController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public IEnumerable<Doctors> Get()
        {
            return _context.Doctors;
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult< Doctors> Get(string id)
        {
            if(id.Length!=9)
                return BadRequest();
            Doctors d = _context.Doctors.Find(item => item.IdD == id);
            if(d == null)
                return NotFound();
            return d;
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public ActionResult Post([FromBody] Doctors d)
        {
            if(d == null||d.IdD.Length!=9)
            {
                return BadRequest();
            }
            _context.Doctors.Add(d);
            return Ok();
        }

        // PUT api/<DoctorsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Doctors d)
        {
            if (id.Length != 9)
            {
                return BadRequest();
            }
            var doctor = _context.Doctors.Find(item=>item.IdD==id);
            if(doctor == null)
            {
                return NotFound();
            }
           int i= _context.Doctors.IndexOf(doctor);
            _context.Doctors.RemoveAt(i);
            _context.Doctors.Insert(i, d);
            return Ok();
        }

        // DELETE api/<DoctorsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            if (id.Length != 9)
            {
                return BadRequest();
            }
            var doctor = _context.Doctors.Find(item => item.IdD == id);
            if (doctor == null)
            {
                return NotFound();
            }
            int i = _context.Doctors.IndexOf(doctor);
            _context.Doctors.RemoveAt(i);
            return Ok();
        }
    }
}
