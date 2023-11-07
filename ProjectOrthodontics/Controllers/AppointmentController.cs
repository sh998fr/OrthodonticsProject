using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private static List<Appointment> _appointments=new List<Appointment>();
        // GET: api/<AppointmentController>
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
          return  _appointments;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            Appointment appoint = _appointments.Find(item => item.CodeA == id);
            return appoint;
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post([FromBody] Appointment ap)
        {
               _appointments.Add(ap);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment ap)
        {
            Appointment appointment = _appointments.Find(item => item.CodeA == id);
           int i= _appointments.IndexOf(appointment);
            _appointments.RemoveAt(i);
            _appointments.Insert(i, ap);
           
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _appointments.Remove(_appointments.Find(item=>item.CodeA == id));
        }
    }
}
