using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    /// <summary>
    /// This respresents a student and their details
    /// Author: Kayley Syrett
    /// </summary>

    public class Student
    {
        //Primary Key
        public int ID { get; set; }
        //Foreign Key
        public string LastName { get; set; }
        //Foreign Key
        public string FirstMidName { get; set; }
        //Foreign Key
        public DateTime EnrollmentDate { get; set; }
        //Navigation property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}