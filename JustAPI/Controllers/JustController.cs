using Microsoft.AspNetCore.Mvc;

namespace JustAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class JustController : ControllerBase
{
    [HttpGet]
    public IActionResult JustGet()
    {
        return Ok();
    }
}