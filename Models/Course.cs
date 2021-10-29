using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        //Primary Key
        public int CourseID { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        //Navigation Property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}