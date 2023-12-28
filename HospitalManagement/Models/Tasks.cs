namespace HospitalManagement.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }
        //add patientID, DoctorsId,
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public User Doctor { get; set; }//Doctor
        public string DoctorUsername { get; set; }

    }
}
