using System;
using System.Linq;
using System.Threading.Tasks;
using UCK.Api.Models.Foundations.Students;

namespace UCK.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Student> InsertStudentAsync(Student student);
        IQueryable<Student> SelectAllStudents();
        ValueTask<Student> SelectStudentByIdAsync(Guid studentId);
        ValueTask<Student> UpdateStudentAsync(Student student);
        ValueTask<Student> DeleteStudentAsync(Student student);
    }
}
