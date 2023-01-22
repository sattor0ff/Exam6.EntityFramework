using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class IssueController:ControllerBase
{
   
        private readonly IssueService _issueService;

        public IssueController(IssueService issueService)
        {
                _issueService = issueService;
        }

        [HttpGet("GetIssues")]
        public List<IssueDto> GetIssues()
        {
                return _issueService.GetIssues();
        }


        [HttpPost("AddIssue")]
        public bool AddIssue(IssueDto issue)
        {
                _issueService.AddIssue(issue);
                return true;
        }

        [HttpPut("UpdateIssue")]
        public bool UpdateIssue(IssueDto issue)
        {
                _issueService.UpdateIssue(issue);
                return true;
        }

        [HttpDelete("DeleteIssue")]
        public void DeleteIssue(int id)
        {
                _issueService.DeleteIssue(id);
        }   
}