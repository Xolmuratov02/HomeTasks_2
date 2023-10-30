using DemoApp.Models;
using DemoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UserController : ControllerBase
{
    private readonly UserService _userService;
    public UserController(UserService userService) 
    {
        _userService = userService;
    }
    [HttpGet]
    public IActionResult Get(Guid id)
    {
        var result = _userService.GetUser(id);
        return Ok(result);
    }

    [HttpPost]
    public IActionResult CReateUser(User user)
    {
        _userService.Create(user);
        return Ok();
    }
}