using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IUser
    {
        ICollection<User> GetUsers();   
    }
}
