using HospitalManagement.Interfaces;
using HospitalManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController: Controller
    {
        private readonly ICategory _category;
        public CategoryController(ICategory category)
        {
                _category = category;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public IActionResult GetCategories()
        {
            var categories = _category.GetCategories();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(categories);
            
        }
    }
}
