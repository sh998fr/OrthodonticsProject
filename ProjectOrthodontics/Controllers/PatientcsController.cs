using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientcsController : ControllerBase
    {private static List<Patientcs> patientcs= new List<Patientcs>();
        // GET: api/<PatientcsController>
        [HttpGet]
        public IEnumerable<Patientcs> Get()
        {
            return patientcs;
        }

        // GET api/<PatientcsController>/5
        [HttpGet("{id}")]
        public Patientcs Get(string id)
        {
            return patientcs.Find(item=>item.IdP==id);
        }

        // POST api/<PatientcsController>
        [HttpPost]
        public void Post([FromBody] Patientcs p)
        {
            patientcs.Add(p);
        }

        // PUT api/<PatientcsController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Patientcs p)
        {
            Patientcs patientcs1 =patientcs.Find(item => item.IdP == id);
            int i = patientcs.IndexOf(patientcs1);
            patientcs.RemoveAt(i);
            patientcs.Insert(i, p);
        }

        // DELETE api/<PatientcsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            int i = patientcs.IndexOf(patientcs.Find( item=>item.IdP==id));
            patientcs.RemoveAt(i);
        }
    }
}
