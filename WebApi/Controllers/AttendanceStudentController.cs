using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AttendaceStudentController:ControllerBase
{
   
        private readonly AttendanceStudentService _attendanceStudentService;

        public AttendaceStudentController(AttendanceStudentService attendanceService)
        {
                _attendanceStudentService = attendanceService;
        }

        [HttpGet("GetAttendances")]
        public List<AttendanceStudentDto> GetAttendaceStudents()
        {
                return _attendanceStudentService.GetAttendanceStudents();
        }


        [HttpPost("AddAttendance")]
        public bool AddAttendanceStudent(AttendanceStudentDto attendance)
        {
                _attendanceStudentService.AddAttendanceStudent(attendance);
                return true;
        }

        [HttpPut("UpdateAttendace")]
        public bool UpdateAttendanceStudent(AttendanceStudentDto attendance)
        {
                _attendanceStudentService.UpdateAttendanceStudent(attendance);
                return true;
        }

        [HttpDelete("DeleteAttendance")]
        public void DeleteAttendanceStudent(int id)
        {
                _attendanceStudentService.DeleteAttendanceStudent(id);
        }   
}