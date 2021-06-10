using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTest2.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public int courseCode { get; set; }
        public string name { get; set; }
        public string teacherName { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    }
}