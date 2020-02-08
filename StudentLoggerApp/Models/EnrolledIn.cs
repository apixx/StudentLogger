using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLoggerApp.Models
{
    public class EnrolledIn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrolledId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string StudentYear { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
