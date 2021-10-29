namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    /// <summary>
    /// This respresents a student enrolled on a course
    /// Author: Kayley Syrett
    /// </summary>
    public class Enrollment
    {
        //Primary Key
        public int EnrollmentID { get; set; }
        //Foreign Key
        public int CourseID { get; set; }
        //Foreign Key
        public int StudentID { get; set; }
        //Enum
        public Grade? Grade { get; set; }

        //Navigation Properties
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
