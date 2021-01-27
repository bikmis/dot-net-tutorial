using MyDataRepository.Entities;

namespace MyDataRepository.Repository
{
    public interface IStudentRepository
    {
        Student RegisterStudent(int id); 
    }
}
