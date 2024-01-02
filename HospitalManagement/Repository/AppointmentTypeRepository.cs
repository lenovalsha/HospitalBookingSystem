using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public class AppointmentTypeRepository : IAppointmentType
    {
        private readonly DataContext _context;
        public AppointmentTypeRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<AppointmentType> GetAppointmentTypes()
        {
            return _context.AppointmentTypes.OrderBy(p => p.Id).ToList();
        }
    }
}
