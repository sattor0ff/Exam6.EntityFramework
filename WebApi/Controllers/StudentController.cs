using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController:ControllerBase
{
   
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
                _studentService = studentService;
        }

        [HttpGet("GetStudents")]
        public async Task<List<StudentDto>> GetStudents()
        {
                return await _studentService.GetStudents();
        }


        [HttpPost("AddStudent")]
        public async Task<bool> AddStudent(StudentDto student)
        {
                await _studentService.AddStudent(student);
                return true;
        }

        [HttpPut("UpdateStudent")]
        public async Task<bool> UpdateStudent(StudentDto student)
        {
                await _studentService.UpdateStudent(student);
                return true;
        }

        [HttpDelete("DeleteStudent")]
        public async Task DeleteStudent(int id)
        {
                await _studentService.DeleteStudent(id);
        }   
}