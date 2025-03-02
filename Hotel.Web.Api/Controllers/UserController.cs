using Hotel.Common.EntityModel.PostgreSql;
using Hotel.Common.EntityModel.PostgreSql.Entities;
using Hotel.Web.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Web.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService service) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User user)
    {
        if (!ModelState.IsValid) return BadRequest();
        bool register = await service.Register(user);
        if (register)
            return Ok();
        return BadRequest();
    }
}