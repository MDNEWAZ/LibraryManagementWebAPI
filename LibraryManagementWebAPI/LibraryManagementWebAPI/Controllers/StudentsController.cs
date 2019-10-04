using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentService _StudentService;

        public StudentsController(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }

        // GET api/Students/5
        [HttpGet("{id}")]
        public List<Student> Get(int id)
        {
            return _StudentService.StudentProfile(id);
        }
    }
}