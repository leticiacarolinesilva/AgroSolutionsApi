using Microsoft.AspNetCore.Mvc;

namespace AgroSolutions.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HealthCheckController : ControllerBase
{
    /// <summary>
    /// Health check endpoint for ingestion service
    /// </summary>
    [HttpGet("health")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Health()
    {
        return Ok(new { status = "healthy", service = "ingestion", timestamp = DateTime.UtcNow });
    }
}
