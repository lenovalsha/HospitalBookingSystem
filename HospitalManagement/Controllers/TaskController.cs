using HospitalManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController :Controller
    {
        private readonly ITasks _tasks;
        public TaskController(ITasks tasks)
        {
            _tasks = tasks;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Task>))]
        public IActionResult GetTasks()
        {
            var task = _tasks.GetTasks();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(task);
        }
    }
}
