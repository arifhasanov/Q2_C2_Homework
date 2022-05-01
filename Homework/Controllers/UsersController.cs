namespace Homework.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private UserService _userService;
    public UsersController(UserService userService)
    {
        _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromQuery] string user, string password)
    {
        string token = _userService.Authenticate(user, password);
        if (string.IsNullOrWhiteSpace(token))
        {
            return BadRequest(new
            {
                message = "Username or password is incorrect"
            });
        }
        return Ok(token);
    }
}
