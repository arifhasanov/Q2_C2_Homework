namespace Homework.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    public CustomersService _customersService;

    public CustomersController(CustomersService customersService)
    {
        _customersService = customersService;   
    }

    [HttpPost("AddCustomer")]
    public async Task<IActionResult> AddCustomer([FromBody]Customer customer)
    {
        await _customersService.Create(customer);
        return Ok();
    }

    [HttpGet("GetAllCustomers")]
    public async Task<IActionResult> GetAllCustomers()
    {
        return Ok(await _customersService.GetAll());
    }

    [HttpGet("GetCustomer/{Id}")]
    public async Task<IActionResult> GetCustomerById(int Id)
    {
        return Ok(await _customersService.Get(Id));
    }

    [HttpPut("UpdateCustomer/{Id}")]
    public async Task<IActionResult> UpdateCustomerById(int Id, [FromBody] Customer customer)
    {
        return Ok(await _customersService.Update(Id, customer));
    }

    [HttpDelete("DeleteCustomerById/{Id}")]
    public async Task<IActionResult> DeleteCustomerById(int Id)
    {
        await _customersService.Delete(Id);
        return Ok();
    }
}