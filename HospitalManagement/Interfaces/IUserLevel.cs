using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IUserLevel
    {
        ICollection<UserLevel> GetUserLevels();
    }
}
