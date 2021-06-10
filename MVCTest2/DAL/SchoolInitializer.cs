using MVCTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCTest2.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{firstName="Mary",surName="Mulvihill",EnrollmentDate=DateTime.Parse("2006-09-01")},
                new Student{firstName="John",surName="Dowling",EnrollmentDate=DateTime.Parse("2007-09-01")},
                new Student{firstName="Patrick",surName="Sheehaan",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{firstName="Rob",surName="Anderson",EnrollmentDate=DateTime.Parse("2004-09-01")},
                new Student{firstName="China",surName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{firstName="Elizabeth",surName="London",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{firstName="Dresta",surName="Johnson",EnrollmentDate=DateTime.Parse("2008-09-01")},
                new Student{firstName="Hannah",surName="O'Connor",EnrollmentDate=DateTime.Parse("2009-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{CourseID=1050,name="Angular 11",      teacherName="Fiona",   courseCode=142   },
                new Course{CourseID=4022,name="C#",              teacherName="Dierdre", courseCode=143   },
                new Course{CourseID=4041,name="Hadoop",          teacherName="Carvalho",courseCode=144   },
                new Course{CourseID=1045,name="UI",              teacherName="Paulo",   courseCode=145   },
                new Course{CourseID=3141,name="Data Science",    teacherName="Denis",   courseCode=146   },
                new Course{CourseID=2021,name="Swift",           teacherName="Christina",courseCode=147  },
                new Course{CourseID=2042,name="Ruby On Rails",   teacherName="John",     courseCode=148  }
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050},
                new Enrollment{StudentID=1,CourseID=4022},
                new Enrollment{StudentID=1,CourseID=4041},
                new Enrollment{StudentID=1,CourseID=1045},
                new Enrollment{StudentID=2,CourseID=1045},
                new Enrollment{StudentID=2,CourseID=3141},
                new Enrollment{StudentID=2,CourseID=2021},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022},
                new Enrollment{StudentID=5,CourseID=4041},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}