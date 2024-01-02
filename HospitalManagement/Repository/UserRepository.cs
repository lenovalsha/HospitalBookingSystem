using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public class UserRepository:IUserLevel
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<UserLevel> GetUserLevels()
        {
            return _context.UserLevels.OrderBy(x => x.Id).ToList();
        }
    }
}
