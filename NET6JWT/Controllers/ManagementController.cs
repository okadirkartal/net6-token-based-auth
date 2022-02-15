using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET6JWT.Data.Helpers;

namespace NET6JWT.Controllers;

[Authorize(Roles = UserRoles.Manager)]
[ApiController]
[Route("[controller]")]
public class ManagementController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Welcome to ManagementController");
    }
}
