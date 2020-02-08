using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLoggerApp.Models
{
    public class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActivityId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime DatePresented { get; set; }
        public int ActivityType { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
