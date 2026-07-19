using System.ComponentModel.DataAnnotations;

namespace MgqsStudentPortal.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string MgqsId { get; set; } = string.Empty;

        public string Major { get; set; } = string.Empty;

        public DateTime ENrollmentDate { get; set; }
    }
}
