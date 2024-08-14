using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SubjectName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
