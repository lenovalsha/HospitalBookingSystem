namespace Hospital_Booking_System.Models
{
    public class Task
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }


        //add patientID, DoctorsId,
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public string DoctorUsername { get; set; }

    }
}
