namespace HospitalManagement.Models
{
    public class AppointmentType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
