using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProjectAPI.Entity;
using StudentProjectAPI.Services;

namespace StudentProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService studentservices;

        // Constructor injection to inject IStudentService dependency
        public StudentController(IStudentService studentservices)
        {
            this.studentservices = studentservices;
        }

        // POST api/student
        [HttpPost]
        public IActionResult Insert(Student student)
        {
            studentservices.AddStudent(student); // Call service method to add a new student
            return Ok(student); // Return 200 OK status with the inserted student object
        }

        // DELETE api/student/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            studentservices.RemoveStudent(id); // Call service method to remove student by ID
            return Ok(); // Return 200 OK status
        }

        // PUT api/student
        [HttpPut]
        public IActionResult Update(Student student)
        {
            studentservices.UpdateStudent(student); // Call service method to update student information
            return Ok(student); // Return 200 OK status with the updated student object
        }
    }
}
