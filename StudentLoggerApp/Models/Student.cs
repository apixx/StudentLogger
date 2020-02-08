using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentLoggerApp.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentId { get; set; }
        public DateTime StudentEnrolledDate { get; set; }
        public DateTime DOB { get; set; }
        public string Description { get; set; }
        public bool IsRegular { get; set; }
    }
}
