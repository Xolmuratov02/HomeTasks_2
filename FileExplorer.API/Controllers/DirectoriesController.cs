using Microsoft.AspNetCore.Mvc;

namespace FileExplorer.API.Controllers;


[ApiController]
[Route("api/[controller]")]

public class DirectoriesControllers : ControllerBase
{
    [HttpGet]
    public string Display()
    {
        return "Hello C#";
    }
}