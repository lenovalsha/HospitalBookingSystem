namespace HospitalManagement.Interfaces
{
    public interface IUserLevel
    {
        ICollection<IUserLevel> GetUserLevels { get; }
    }
}
