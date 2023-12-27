using System.ComponentModel.DataAnnotations;

namespace Hospital_Booking_System.Models
{
    public class Patient
    {
        [Key]
        public int HSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public string Phone { get; set; }

        //DoctorId
        public Doctor Doctor { get; set; }
        public string DoctorUsername { get; set; }

    }
}
