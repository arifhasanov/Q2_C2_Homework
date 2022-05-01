namespace Homework.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class EmployeesController : ControllerBase
{
    public EmployeesService _employeesService;

    public EmployeesController(EmployeesService employeesService)
    {
        _employeesService = employeesService;
    }

    [HttpPost("AddEmployee")]
    public async Task<IActionResult> AddEmployee([FromBody] EmployeeVM employee)
    {
        await _employeesService.Create(employee);
        return Ok();
    }

    [HttpGet("GetAllEmployees")]
    public async Task<IActionResult> GetAllEmployees()
    {
        return Ok(await _employeesService.GetAll());
    }

    [HttpGet("GetEmployee/{Id}")]
    public async Task<IActionResult> GetEmployeeById(int Id)
    {
        return Ok(await _employeesService.Get(Id));
    }

    [HttpPut("UpdateEmployee/{Id}")]
    public async Task<IActionResult> UpdateEmployeeById(int Id, [FromBody] EmployeeVM employee)
    {
        return Ok(await _employeesService.Update(Id, employee));
    }

    [HttpDelete("DeleteEmployeeById/{Id}")]
    public async Task<IActionResult> DeleteEmployeeById(int Id)
    {
        await _employeesService.Delete(Id);
        return Ok();
    }
}
