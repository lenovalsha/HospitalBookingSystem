using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IAppointmentType
    {
        ICollection<AppointmentType> GetAppointmentTypes();
        AppointmentType GetAppointmentTypeById(int id);
        AppointmentType GetAppointmentTypeByName(string name);

        bool AppointmentTypeExist (int id);  
    }
}
