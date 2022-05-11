using Microsoft.AspNetCore.Mvc;
using server.Models;

namespace server.Controllers;

[ApiController]
[Route("")]
public class UserController : ControllerBase
{
    [HttpPost("createuser")]
    public async Task<object> createuser([FromBody]User user)
    {
        await user.Save();
        return new {
            status = "OK",
            userid = user.Id
        };
    }
}
