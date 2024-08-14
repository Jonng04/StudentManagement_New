using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        [Range(0, 10)]
        public float Score { get; set; }
    }
}
