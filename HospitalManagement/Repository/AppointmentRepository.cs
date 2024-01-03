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

        public Appointment GetAppointment(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Appointment> GetAppointments()
        {
            return _context.Appointments.OrderBy(p => p.Id).ToList();
        }

        public bool IsAppointmentExist(int id)
        {
            return _context.Appointments.Any(x=>x.Id==id);
        }

        public Appointment GetAppointment(int id)
        {
            return _context.Appointments.Where(p => p.Id == id).FirstOrDefault();
        }

       
    }
}
