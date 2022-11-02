using infinity_talent.Data.Services;
using infinity_talent.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace infinity_talent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        public CandidatesService _canndidateService;
        public CandidatesController(CandidatesService canndidateService)
        {
            _canndidateService = canndidateService;
        }

        [HttpPost("add-candidate")]
        public IActionResult AddCandidate([FromBody] CandidateVM candidate)
        {
            _canndidateService.AddCandidate(candidate);
            return Ok();
        }

        [HttpGet("get-all-candidates")]
        public IActionResult GetAllCandidates()
        {
            var allCandidates = _canndidateService.GetAllCandidates();
            return Ok(allCandidates);
        }

        [HttpGet("get-candidate-by-id/{id}")]
        public IActionResult GetCandidateById(int id)
        {
            var candidate = _canndidateService.GetCandidateById(id);
            return Ok(candidate);
        }

        [HttpPut("update-candidate-by-id/{id}")]
        public IActionResult UpdateCandidate(int id, [FromBody] CandidateVM candidate)
        {
            var updateCandidate = _canndidateService.UpdateCandidate(id, candidate);
            return Ok(updateCandidate);
        }

        [HttpDelete("delete-candidate-by-id/{id}")]
        public IActionResult DeleteCandidateById(int id)
        {
            _canndidateService.DeleteBookById(id);
            return Ok();
        }
    }
}
