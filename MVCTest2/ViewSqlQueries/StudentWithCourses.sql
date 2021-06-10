CREATE VIEW [StudentCourses] AS
SELECT Student.firstName, Student.surName, Course.name,Course.teacherName FROM Student inner join Enrollment on Student.id = Enrollment.StudentID
inner join  Course on Course.CourseID = Enrollment.CourseID;