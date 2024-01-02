using HospitalManagement.Models;

namespace HospitalManagement.Interfaces
{
    public interface IPatient
    {
        ICollection<Patient> GetPatients();
    }
}
