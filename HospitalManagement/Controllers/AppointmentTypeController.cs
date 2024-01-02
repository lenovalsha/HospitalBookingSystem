using HospitalManagement.Interfaces;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentTypeController:Controller
    {
        private readonly IAppointmentType _appointmentType;
        public AppointmentTypeController(IAppointmentType appointmentType)
        {
            _appointmentType = appointmentType;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<AppointmentType>))]
        public IActionResult GetAppointmentTypes() 
        {
            var at = _appointmentType.GetAppointmentTypes();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(at);
        }
    }
}
