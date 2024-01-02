using HospitalManagement.Interfaces;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLevelController : Controller
    {
        private readonly IUserLevel _userLevel;

        public UserLevelController(IUserLevel userLevel)
        {
            _userLevel = userLevel;
            
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<UserLevel>))]
        public IActionResult GetUserLevels()
        {
            var UserLevels = _userLevel.GetUserLevels();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(UserLevels);

        }
    }
}
