using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using School.API.Models;
using School.API.ViewModels;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors]
    public class StudentsController : ControllerBase
    {
        private IDataProtector _protector;
        public StudentsController(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("StudentController");
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var name = "LinkedIn Learning";

            var protectedValue = _protector.Protect(name);
            var unprotectedValue = _protector.Unprotect(protectedValue);

            var result = $"{protectedValue} - {unprotectedValue}";

            return Ok(result);
        }


        // POST api/students
        [HttpPost]
        public void Post([FromBody] StudentVM student)
        {
            var requestData = student;
            //Save data to DB
        }

        public Student GetStudentByName()
        {
            //Parameter
            string name = "John; DELETE From Students;";

            SqlCommand cmd = new SqlCommand($"SELECT * FROM Students WHERE FirstName={name}");

            SqlCommand pcmd = new SqlCommand($"SELECT * FROM Students WHERE FirstName=@firstname");
            pcmd.Parameters.Add("@firstname", System.Data.SqlDbType.NVarChar);
            pcmd.Parameters["@firstname"].Value = name;

            return new Student();
        }


        private IEnumerable<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    FullName = "John Smith",
                    GPA = 3.8,
                    School = new Models.School()
                    {
                        Id = 1,
                        Name = "GW School",
                        Address = "GW Street"
                    }
                },
                new Student()
                {
                    Id=1,
                    FullName = "John Smith",
                    GPA = 3.8,
                    School = new Models.School()
                    {
                        Id = 1,
                        Name = "GW School",
                        Address = "GW Street"
                    }
                }
            };
        }
    }
}