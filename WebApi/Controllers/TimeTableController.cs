using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeTableController:ControllerBase
{
   
        private readonly TimeTableService _timetableService;

        public TimeTableController(TimeTableService timeTableService)
        {
                _timetableService = timeTableService;
        }

        [HttpGet("GetTimeTables")]
        public List<TimeTableDto> GetTimeTables()
        {
                return _timetableService.GetTimeTables();
        }


        [HttpPost("AddTimeTable")]
        public bool AddTimeTable(TimeTableDto timeTable)
        {
                _timetableService.AddTimeTable(timeTable);
                return true;
        }

        [HttpPut("UpdateTimeTable")]
        public bool UpdateTimeTable(TimeTableDto timeTable)
        {
                _timetableService.UpdateTimeTable(timeTable);
                return true;
        }

        [HttpDelete("DeleteTimeTable")]
        public void DeleteTimeTable(int id)
        {
                _timetableService.DeleteTimeTable(id);
        }   
}