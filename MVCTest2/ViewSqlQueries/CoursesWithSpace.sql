CREATE VIEW [CoursesWithSpace] As
SELECT Course.name, Count(Enrollment.StudentID) as No_of_Students FROM Course 
inner join Enrollment on Course.CourseID = Enrollment.CourseID
Group by Course.name
HAVING COUNT(Enrollment.StudentID) < 5;