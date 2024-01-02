using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IAppointmentType
    {
        ICollection<AppointmentType> GetAppointmentTypes();
    }
}
