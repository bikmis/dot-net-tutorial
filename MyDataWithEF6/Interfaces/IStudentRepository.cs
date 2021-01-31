using MyDataWithEF6.Entities;

namespace MyDataWithEF6.Interfaces
{
    public interface IStudentRepository
    {
        Student RegisterStudent(int id); 
    }
}
