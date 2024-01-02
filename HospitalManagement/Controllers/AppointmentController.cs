using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;
using HospitalManagement.Interfaces;


namespace HospitalManagement.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class AppointmentController :Controller
    {
        private readonly IAppointment _appointment;

        public AppointmentController(IAppointment appointment)
        {
            _appointment = appointment;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Appointment>))]
        public IActionResult GetAppointments()
        {
            var apt = _appointment.GetAppointments();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(apt);
        }

    }
}
