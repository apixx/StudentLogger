namespace StudentLoggerApp.RequestModels
{
    public class EnrollMultipleStudentsModel
    {
        public int[] StudentIds { get; set; }
        public int CourseId { get; set; }
    }
}
