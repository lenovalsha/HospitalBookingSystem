using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public class TaskRepository:ITasks
    {
        private readonly DataContext _context;
        public TaskRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Tasks> GetTasks()
        {
           return _context.Tasks.OrderBy(t => t.Id).ToList();
        }
    }
}
