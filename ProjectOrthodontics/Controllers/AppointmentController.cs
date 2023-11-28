using Microsoft.AspNetCore.Mvc;
using ProjectOrthodontics.Core.Entities;
using ProjectOrthodontics.Core.Services;
using ProjectOrthodontics.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectOrthodontics.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;   
        }
        // GET: api/<AppointmentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appointmentService.GetAppointment());
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Appointment appoint = _appointmentService.GetAppointment().First(item => item.CodeA == id);
            if(appoint == null)
            {
                return NotFound();
            }
            return Ok(appoint);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public IActionResult Post([FromBody] Appointment ap)
        {
            if(ap == null)
                return NotFound();
               _appointmentService.GetAppointment().Add(ap);
            return Ok(_appointmentService.GetAppointment());
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Appointment ap)
        {
            Appointment appointment = _appointmentService.GetAppointment().First(item => item.CodeA == id);
            if (appointment == null)
            {
              return  NotFound();
            }
            if(ap == null)
            {
                return BadRequest();
            }
            
                int i = _appointmentService.GetAppointment().IndexOf(appointment);
                _appointmentService.GetAppointment().RemoveAt(i);
                _appointmentService.GetAppointment().Insert(i, ap);
            
            return Ok();
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Appointment a = _appointmentService.GetAppointment().First(item => item.CodeA == id);
                if(a == null)
            { return NotFound();}
               
          
             _appointmentService.GetAppointment().Remove(a);
            return Ok(_appointmentService.GetAppointment());
        }
    }
}
