CREATE VIEW [StudentsNotMaxRegistered] AS
SELECT Student.firstName,Student.surName, Count(Enrollment.CourseID) as No_of_Courses FROM Student 
inner join Enrollment on Student.id = Enrollment.StudentID
Group by Student.firstName,Student.surName
HAVING COUNT(Enrollment.CourseID) < 6;