using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private DataContext _context;
        public AppointmentController(DataContext context)
        {
_context = context;
        }
        // GET: api/<AppointmentController>
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return _context.Appointments;
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Appointment> Get(int id)
        {
            Appointment appoint = _context.Appointments.Find(item => item.CodeA == id);
            if(appoint == null)
            {
                return NotFound();
            }
            return appoint;
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public void Post([FromBody] Appointment ap)
        {
               _context.Appointments.Add(ap);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Appointment ap)
        {
            Appointment appointment = _context.Appointments.Find(item => item.CodeA == id);
            if (appointment == null)
            {
              return  NotFound();
            }
            if(ap == null)
            {
                return BadRequest();
            }
            
                int i = _context.Appointments.IndexOf(appointment);
                _context.Appointments.RemoveAt(i);
                _context.Appointments.Insert(i, ap);
            
            return Ok();
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Appointment a = _context.Appointments.Find(item => item.CodeA == id);
                if(a == null)
            { return NotFound();}
               
          
             _context.Appointments.Remove(a);
            return Ok();
        }
    }
}
