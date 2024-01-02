using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public class UserRepository:IUser
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(x => x.Username).ToList();
        }
    }
}
