using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Core.Entities;
using ProjectOrthodontics.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientcsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientcsController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        // GET: api/<PatientcsController>
        [HttpGet]
        public IEnumerable<Patientcs> Get()
        {
            return _patientService.GetAllPatientcs();
        }

        // GET api/<PatientcsController>/5
        [HttpGet("{id}")]
        public ActionResult< Patientcs> Get(string id)
        {
            if(id.Length!=9)
                return BadRequest();
            Patientcs p= _patientService.GetAllPatientcs().Find(item => item.IdP == id);
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
            _patientService.GetAllPatientcs().Add(p);
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
            Patientcs patientcs1 = _patientService.GetAllPatientcs().Find(item => item.IdP == id);
            if (patientcs1 == null)
            {
                return NotFound();
            }
            int i = _patientService.GetAllPatientcs().IndexOf(patientcs1);
            _patientService.GetAllPatientcs().RemoveAt(i);
            _patientService.GetAllPatientcs().Insert(i, p);
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
            Patientcs p = _patientService.GetAllPatientcs().Find(item => item.IdP == id);
            if (p == null)
            {
                return NotFound();
            }
            int i = _patientService.GetAllPatientcs().IndexOf(p);
            _patientService.GetAllPatientcs().RemoveAt(i);
            return Ok();
        }
    }
}
