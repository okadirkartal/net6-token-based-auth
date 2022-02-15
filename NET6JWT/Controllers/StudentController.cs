using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET6JWT.Data.Helpers;

namespace NET6JWT.Controllers;

[Authorize(Roles = UserRoles.Student)]
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Welcome to StudentController");
    }
}
