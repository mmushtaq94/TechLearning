namespace School.Models
{
    public class Student
    {
        // Primary key
        public int StudentId { get; set; }

        // Student properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Foreign key relationship to other entities can go here, e.g.:
        // public int ClassId { get; set; }
        // public Class Class { get; set; }
    }
}