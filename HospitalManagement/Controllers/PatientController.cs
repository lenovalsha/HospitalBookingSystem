using HospitalManagement.Interfaces;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly IPatient _patient;

        public PatientController(IPatient patient)
        {
            _patient = patient;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Patient>))]
        public IActionResult GetPatients()
        {
            var patients = _patient.GetPatients();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(patients);
        }
    }
}
