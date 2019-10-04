using LibraryManagementWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebAPI
{
    public class StudentService:IStudentService
    {
        private IStudentRepository _StudentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _StudentRepository = studentRepository;
        }

        public List<Student> StudentProfile(int Id)
        {
            return _StudentRepository.GetStudentInfo(Id);
        }
    }
}
