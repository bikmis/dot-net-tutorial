using MyDataRepository.Entities;

namespace MyDataRepository.Interfaces
{
    public interface IStudentRepository
    {
        Student RegisterStudent(int id); 
    }
}
