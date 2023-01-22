using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ResultController:ControllerBase
{
   
        private readonly ResultService _resultService;

        public ResultController(ResultService ResultService)
        {
                _resultService = ResultService;
        }

        [HttpGet("GetResults")]
        public List<ResultDto> GetResults()
        {
                return _resultService.GetResults();
        }


        [HttpPost("AddResult")]
        public bool AddResult(ResultDto result)
        {
                _resultService.AddResult(result);
                return true;
        }

        [HttpPut("UpdateResult")]
        public bool UpdateResult(ResultDto result)
        {
                _resultService.UpdateResult(result);
                return true;
        }

        [HttpDelete("DeleteResult")]
        public void DeleteResult(int id)
        {
                _resultService.DeleteResult(id);
        }   
}