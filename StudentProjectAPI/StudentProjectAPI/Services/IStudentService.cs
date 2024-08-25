using StudentProjectAPI.Entity;
namespace StudentProjectAPI.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void RemoveStudent(int id);
        void UpdateStudent(Student student);
    }
}
