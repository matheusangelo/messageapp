using Microsoft.AspNetCore.Mvc;

namespace MessageApp.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{

    private readonly ILogger<MessageController> _logger;

    public MessageController(ILogger<MessageController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "InitialGet")]
    public IActionResult Get()
    {
        _logger.LogInformation("Init");
        return Ok("Ok");
    }
}
