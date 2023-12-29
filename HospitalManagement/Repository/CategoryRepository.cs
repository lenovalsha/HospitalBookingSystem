using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public class CategoryRepository :ICategory
    {
        private readonly DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Category> GetCategories()
        {
            return _context.Categories.OrderBy(p=>p.Id).ToList();
        }

    }
}
