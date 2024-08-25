using StudentProjectAPI.Entity;
using StudentProjectAPI.Repository;
using StudentProjectAPI.Services;

namespace StudentProjectAPI.Services
{
    // Implementation of the IStudentService interface
    public class StudentService : IStudentService
    {
        // Database context instance
        private readonly StudentDbContext studentDbContext = new StudentDbContext();

        // Method to add a new student to the database
        public void AddStudent(Student student)
        {
            // Using statement ensures resources are properly disposed
            using (var context = new StudentDbContext())
            {
                context.students.Add(student); // Add the student entity to the context
                context.SaveChanges(); // Save changes to the database
            }
        }

        // Method to remove a student from the database by ID
        public void RemoveStudent(int id)
        {
            var context = studentDbContext.students.Find(id); // Find the student by ID
            if (context != null)
            {
                studentDbContext.students.Remove(context); // Remove the student from the context
                studentDbContext.SaveChanges(); // Save changes to the database
            }
        }

        // Method to update an existing student's information in the database
        public void UpdateStudent(Student student)
        {
            var context = studentDbContext.students.Find(student.Student_ID); // Find the student by ID
            if (context != null)
            {
                // Update the student's properties
                context.Student_ID = student.Student_ID;
                context.Student_Name = student.Student_Name;

                studentDbContext.students.Update(context); // Update the student in the context
                studentDbContext.SaveChanges(); // Save changes to the database
            }
        }
    }
}
