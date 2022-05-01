namespace Homework.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class JobTasksController : ControllerBase
{
    public JobTasksService _service;

    public JobTasksController(JobTasksService service)
    {
        _service = service;
    }

    [HttpPost("AddJobTask")]
    public async Task<IActionResult> Add([FromBody] JobTaskVM jobtask)
    {
        await _service.Create(jobtask);
        return Ok();
    }

    [HttpGet("GetAllJobTasks")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAll());
    }

    [HttpGet("GetJobTask/{Id}")]
    public async Task<IActionResult> GetById(int Id)
    {
        return Ok(await _service.Get(Id));
    }

    [HttpPut("UpdateJobTask/{Id}")]
    public async Task<IActionResult> UpdateById(int Id, [FromBody] JobTaskVM jobtask)
    {
        return Ok(await _service.Update(Id, jobtask));
    }

    [HttpDelete("DeleteJobTaskById/{Id}")]
    public async Task<IActionResult> DeleteById(int Id)
    {
        await _service.Delete(Id);
        return Ok();
    }
}
