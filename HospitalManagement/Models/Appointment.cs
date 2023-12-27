namespace Hospital_Booking_System.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public int PatientHSN { get; set; }

        public Doctor Doctor { get; set; }
        public string DoctorUsername { get; set; }

        public AppointmentType AppointmentType { get; set; }
        public int AppointmentTypeId { get; set; }
        public int MyProperty { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
