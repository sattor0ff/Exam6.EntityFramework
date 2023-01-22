using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SubjectController:ControllerBase
{
   
        private readonly SubjectService _subjectService;

        public SubjectController(SubjectService subjectService)
        {
                _subjectService = subjectService;
        }

        [HttpGet("GetSubjects")]
        public List<SubjectDto> GetSubjects()
        {
                return _subjectService.GetSubjects();
        }


        [HttpPost("AddSubject")]
        public bool AddSubject(SubjectDto subject)
        {
                _subjectService.AddSubject(subject);
                return true;
        }

        [HttpPut("UpdateSubject")]
        public bool UpdateSubject(SubjectDto subject)
        {
                _subjectService.UpdateSubject(subject);
                return true;
        }

        [HttpDelete("DeleteSubject")]
        public void DeleteSubject(int id)
        {
                _subjectService.DeleteSubject(id);
        }   
}