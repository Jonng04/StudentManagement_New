using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string? TeacherCode { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }
        public string? Address { get; set; }

        [Phone]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
