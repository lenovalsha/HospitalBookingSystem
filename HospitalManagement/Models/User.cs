using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //userLevelId

        public UserLevel UserLevel { get; set; } //0 for admin - 1 for doctocs/np - 2 for regular users
        public int UserLevelId { get; set; }

        public List<Tasks> Tasks { get; set; }
        public List<Appointment> Appointments { get; set; }
        public ICollection<Patient> Patients { get; set; }
    }
}
