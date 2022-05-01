namespace Homework.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class InvoicesController : ControllerBase
{
    public InvoicesService _service;

    public InvoicesController(InvoicesService service)
    {
        _service = service;
    }

    [HttpPost("AddInvoice")]
    public async Task<IActionResult> Add([FromBody] InvoiceVM invoice)
    {
        await _service.Create(invoice);
        return Ok();
    }

    [HttpGet("GetAllInvoices")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAll());
    }

    [HttpGet("GetInvoice/{Id}")]
    public async Task<IActionResult> GetById(int Id)
    {
        return Ok(await _service.Get(Id));
    }

    [HttpPut("UpdateInvoice/{Id}")]
    public async Task<IActionResult> UpdateById(int Id, [FromBody] InvoiceVM invoice)
    {
        return Ok(await _service.Update(Id, invoice));
    }

    [HttpDelete("DeleteInvoiceById/{Id}")]
    public async Task<IActionResult> DeleteById(int Id)
    {
        await _service.Delete(Id);
        return Ok();
    }
}
