using Azure.Core;
using HospitalManagement.Data;
using HospitalManagement.Interfaces;
using HospitalManagement.Models;

namespace HospitalManagement.Repository
{
    public class PatientRepository: IPatient
    {
        private readonly DataContext _context;
        public PatientRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Patient> GetPatients()
        {
            return _context.Patients.OrderBy(p=>p.HSN).ToList();
        }
    }
}
