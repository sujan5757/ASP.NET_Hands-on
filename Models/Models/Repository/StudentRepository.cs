using Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace Models.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> GetAllStudents()
        {
            return DataSource();
        }

        public List<StudentModel> getAllStudents()
        {
            throw new NotImplementedException();
        }

        public StudentModel GetStudentById(int id)
        {
            return DataSource().FirstOrDefault(x => x.RollNo == id);
        }

        public StudentModel getstudentById(int id)
        {
            throw new NotImplementedException();
        }

        private List<StudentModel> DataSource()
        {
            // Initialize the list of students
            var students = new List<StudentModel>
            {
                new StudentModel { RollNo = 1, Name = "sujanps", Gender = "Male", Standard = 11 },
                new StudentModel { RollNo = 2, Name = "sujan", Gender = "Male", Standard = 11 },
                new StudentModel { RollNo = 3, Name = "suja", Gender = "Female", Standard = 12 },
                new StudentModel { RollNo = 4, Name = "anam", Gender = "Female", Standard = 12 },
                new StudentModel { RollNo = 5, Name = "perm", Gender = "Male", Standard = 12 }
            };

            return students;
        }
    }
}
