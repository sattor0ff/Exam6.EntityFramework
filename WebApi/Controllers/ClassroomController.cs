using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassroomController:ControllerBase
{
   
        private readonly ClassroomService _classroomService;

        public ClassroomController(ClassroomService classroomService)
        {
                _classroomService = classroomService;
        }

        [HttpGet("GetClassrooms")]
        public List<ClassroomDto> GetClassrooms()
        {
                return _classroomService.GetClassrooms();
        }


        [HttpPost("AddClassroom")]
        public bool AddClassroom(ClassroomDto classroom)
        {
                _classroomService.AddClassroom(classroom);
                return true;
        }

        [HttpPut("UpdateClassroom")]
        public bool UpdateClassroom(ClassroomDto classroom)
        {
                _classroomService.UpdateClassroom(classroom);
                return true;
        }

        [HttpDelete("DeleteClassroom")]
        public void DeleteClassroom(int id)
        {
                _classroomService.DeleteClassroom(id);
        }   
}