using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public class AppointmentRepository : IAppointment
    {
        private readonly DataContext _context;
        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Appointment> GetAppointments()
        {
            return _context.Appointments.OrderBy(p => p.Id).ToList();
        }

     
    }
}
