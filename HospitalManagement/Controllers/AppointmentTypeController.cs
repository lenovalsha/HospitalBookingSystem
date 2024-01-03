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
        [ProducesResponseType(200, Type = typeof(IEnumerable<AppointmentType>))] //makes api endpoint look cleaner // serves no other purpose
        public IActionResult GetAppointmentTypes() 
        {
            var at = _appointmentType.GetAppointmentTypes();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(at);
        }

        [HttpGet("{id}")]
        public IActionResult GetAppointmentTypeById(int id)
        {
            if(!_appointmentType.AppointmentTypeExist(id))
                return NotFound();
            var aptType = _appointmentType.GetAppointmentTypeById(id);

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(aptType);
        }
        [HttpGet("{id}")]
    }
}
