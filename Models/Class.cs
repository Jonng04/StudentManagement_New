using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Class
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string ClassName { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
