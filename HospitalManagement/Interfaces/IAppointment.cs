using HospitalManagement.Models;
using Microsoft.AspNetCore.OutputCaching;

namespace HospitalManagement.Interfaces
{
    public interface IAppointment
    {
        ICollection<Appointment> GetAppointments();
        Appointment GetAppointment(int id);
        Appointment GetAppointment(string name);

        bool IsAppointmentExist(int id);

    }
}
