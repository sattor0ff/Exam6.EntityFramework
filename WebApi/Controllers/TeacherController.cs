using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController:ControllerBase
{
   
        private readonly TeacherService _teacherService;

        public TeacherController(TeacherService teacherService)
        {
                _teacherService = teacherService;
        }

        [HttpGet("GetTeachers")]
        public List<TeacherDto> GetTeachers()
        {
                return _teacherService.GetTeachers();
        }


        [HttpPost("AddTeacher")]
        public bool AddTeacher(TeacherDto teacher)
        {
                _teacherService.AddTeacher(teacher);
                return true;
        }

        [HttpPut("UpdateTeacher")]
        public bool UpdateTeacher(TeacherDto teacher)
        {
                _teacherService.UpdateTeacher(teacher);
                return true;
        }

        [HttpDelete("DeleteTeacher")]
        public void DeleteTeacher(int id)
        {
                _teacherService.DeleteTeacher(id);
        }   
}