using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IAppointment
    {
        ICollection<Appointment> GetAppointments();
    }
}
