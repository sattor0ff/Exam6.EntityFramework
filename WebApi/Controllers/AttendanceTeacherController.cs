using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AttendaceTeacherController:ControllerBase
{
   
        private readonly AttendanceTeacherService _attendanceTeacherService;

        public AttendaceTeacherController(AttendanceTeacherService attendanceService)
        {
                _attendanceTeacherService = attendanceService;
        }

        [HttpGet("GetAttendances")]
        public List<AttendanceTeacherDto> GetAttendaceTeachers()
        {
                return _attendanceTeacherService.GetAttendanceTeachers();
        }


        [HttpPost("AddAttendance")]
        public bool AddAttendanceTeacher(AttendanceTeacherDto attendance)
        {
                _attendanceTeacherService.AddAttendanceTeacher(attendance);
                return true;
        }

        [HttpPut("UpdateAttendace")]
        public bool UpdateAttendanceTeacher(AttendanceTeacherDto attendance)
        {
                _attendanceTeacherService.UpdateAttendanceTeacher(attendance);
                return true;
        }

        [HttpDelete("DeleteAttendance")]
        public void DeleteAttendanceTeacher(int id)
        {
                _attendanceTeacherService.DeleteAttendanceTeacher(id);
        }   
}