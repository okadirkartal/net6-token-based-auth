using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET6JWT.Data.Helpers;

namespace NET6JWT.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize(Roles = UserRoles.Student + "," + UserRoles.Manager)]
public class HomeController : ControllerBase
{
    [HttpGet("student")]
    [Authorize(Roles = UserRoles.Student)]
    public IActionResult GetStudent()
    {
        return Ok("Welcome to HomeController - Student");
    }

    [HttpGet("manager")]
    [Authorize(Roles = UserRoles.Manager)]
    public IActionResult GetManager()
    {
        return Ok("Welcome to HomeController - Manager");
    }
}
