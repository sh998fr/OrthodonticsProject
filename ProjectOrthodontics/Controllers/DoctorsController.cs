using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Core.Entities;
using ProjectOrthodontics.Core.Services;
using ProjectOrthodontics.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        // GET: api/<DoctorsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_doctorService.GetDoctors());
        }

        // GET api/<DoctorsController>/5
        [HttpGet("{id}")]
        public ActionResult< Doctors> Get(string id)
        {
            if(id.Length!=9)
                return BadRequest();
            Doctors d = _doctorService.GetDoctors().FirstOrDefault(item => item.ID == id);
            if(d == null)
                return NotFound();
            return d;
        }

        // POST api/<DoctorsController>
        [HttpPost]
        public ActionResult Post([FromBody] Doctors d)
        {
            if(d == null||d.ID.Length!=9)
            {
                return BadRequest();
            }
            _doctorService.GetDoctors().Add(d);
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
            var doctor = _doctorService.GetDoctors().Find(item=>item.ID==id);
            if(doctor == null)
            {
                return NotFound();
            }
           int i= _doctorService.GetDoctors().IndexOf(doctor);
            _doctorService.GetDoctors().RemoveAt(i);
            _doctorService.GetDoctors().Insert(i, d);
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
            var doctor = _doctorService.GetDoctors().Find(item => item.ID == id);
            if (doctor == null)
            {
                return NotFound();
            }
            int i = _doctorService.GetDoctors().IndexOf(doctor);
            _doctorService.GetDoctors().RemoveAt(i);
            return Ok();
        }
    }
}
