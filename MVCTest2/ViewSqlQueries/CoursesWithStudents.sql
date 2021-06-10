CREATE VIEW CoursesStudents AS
SELECT  Course.name,Course.teacherName, Student.firstName, Student.surName FROM Course 
inner join Enrollment on Course.CourseID = Enrollment.CourseID
INNER JOIN Student on Student.id = Enrollment.StudentID;