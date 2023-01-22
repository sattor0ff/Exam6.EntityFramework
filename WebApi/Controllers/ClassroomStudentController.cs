using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassroomStudentController:ControllerBase
{
   
        private readonly ClassroomStudentService _classroomStudentService;

        public ClassroomStudentController(ClassroomStudentService classroomStudentService)
        {
                _classroomStudentService = classroomStudentService;
        }

        [HttpGet("GetClassroomStudents")]
        public List<ClassroomStudentDto> GetClassroomStudents()
        {
                return _classroomStudentService.GetClassroomStudents();
        }


        [HttpPost("AddClassroomStudent")]
        public bool AddClassroomStudent(ClassroomStudentDto classroomStudent)
        {
                _classroomStudentService.AddClassroomStudent(classroomStudent);
                return true;
        }

        [HttpPut("UpdateClassroomStudent")]
        public bool UpdateClassroomStudent(ClassroomStudentDto classroomStudent)
        {
                _classroomStudentService.UpdateClassroomStudent(classroomStudent);
                return true;
        }

        [HttpDelete("DeleteClassroomStudent")]
        public void DeleteClassroomStudent(int id)
        {
                _classroomStudentService.DeleteClassroomStudent(id);
        }   
}