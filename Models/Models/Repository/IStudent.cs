using Models.Models;

namespace Models.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudents();
        StudentModel getstudentById(int id);
    }
}
