namespace Corso.Controller
{
    using Corso.Services;
    using Corso.Services.DTOs;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class AuleController : ControllerBase
    {
        private readonly IAulaService _aulaService;

        public AuleController(IAulaService aulaService)
        {
            _aulaService = aulaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AulaDTO>>> GetAule()
        {
            return await _aulaService.GetAuleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<AulaDTO>> AddAula([FromBody] CreateAulaDTO aulaDto)
        {
            await _aulaService.AddAulaAsync(aulaDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAula(int id)
        {
            await _aulaService.DeleteAulaAsync(id);
            return NoContent();
        }
    }
}
