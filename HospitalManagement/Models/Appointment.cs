using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public int PatientHSN { get; set; }

        [ForeignKey("UserUsername")]
        public User? User { get; set; }//Doctors
        public string? UserUsername { get; set; } 

        public AppointmentType AppointmentType { get; set; }
        public int AppointmentTypeId { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
