using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface ICategory
    {
        ICollection<Category> GetCategories();
    }
}
