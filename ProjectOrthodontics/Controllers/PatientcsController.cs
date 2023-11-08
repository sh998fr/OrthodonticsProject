using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientcsController : ControllerBase
    {
        private DataContext _context;
        public PatientcsController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<PatientcsController>
        [HttpGet]
        public IEnumerable<Patientcs> Get()
        {
            return _context.Patientcs;
        }

        // GET api/<PatientcsController>/5
        [HttpGet("{id}")]
        public ActionResult< Patientcs> Get(string id)
        {
            if(id.Length!=9)
                return BadRequest();
            Patientcs p= _context.Patientcs.Find(item => item.IdP == id);
            if(p==null)
                return NotFound();
            return p;
        }

        // POST api/<PatientcsController>
        [HttpPost]
        public ActionResult Post([FromBody] Patientcs p)
        {
            if(p==null||p.IdP.Length!=9)
                return BadRequest();
            _context.Patientcs.Add(p);
            return Ok();
        }

        // PUT api/<PatientcsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Patientcs p)
        {
            if (id.Length != 9)
            {
                return BadRequest();
            }
            Patientcs patientcs1 = _context.Patientcs.Find(item => item.IdP == id);
            if (patientcs1 == null)
            {
                return NotFound();
            }
            int i = _context.Patientcs.IndexOf(patientcs1);
            _context.Patientcs.RemoveAt(i);
            _context.Patientcs.Insert(i, p);
            return Ok();
        }

        // DELETE api/<PatientcsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            if(id.Length != 9)
            {
                return BadRequest();
            }
            Patientcs p = _context.Patientcs.Find(item => item.IdP == id);
            if (p == null)
            {
                return NotFound();
            }
            int i = _context.Patientcs.IndexOf(p);
            _context.Patientcs.RemoveAt(i);
            return Ok();
        }
    }
}
