using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Subject { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public ICollection<Student> Students { get; set; }
    }

}