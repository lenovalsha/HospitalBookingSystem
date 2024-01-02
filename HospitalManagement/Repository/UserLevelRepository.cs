using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;


namespace HospitalManagement.Repository
{
    public class UserLevelRepository : IUserLevel
    {
        private readonly DataContext _context;
        public UserLevelRepository(DataContext context)
        {
            _context = context;
        }


        public ICollection<UserLevel> GetUserLevels()
        {
            return _context.UserLevels.OrderBy(p => p.Id).ToList();
        }
    }
}
