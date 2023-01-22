using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExamController:ControllerBase
{
   
        private readonly ExamService _examService;

        public ExamController(ExamService examService)
        {
                _examService = examService;
        }

        [HttpGet("GetExams")]
        public List<ExamDto> GetExams()
        {
                return _examService.GetExams();
        }


        [HttpPost("AddExam")]
        public bool AddExam(ExamDto exam)
        {
                _examService.AddExam(exam);
                return true;
        }

        [HttpPut("UpdateExam")]
        public bool UpdateExam(ExamDto exam)
        {
                _examService.UpdateExam(exam);
                return true;
        }

        [HttpDelete("DeleteExam")]
        public void DeleteExam(int id)
        {
                _examService.DeleteExam(id);
        }   
}