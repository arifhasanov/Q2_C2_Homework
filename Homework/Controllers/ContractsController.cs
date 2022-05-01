namespace Homework.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ContractsController : ControllerBase
{
    public ContractsService _contractsService;

    public ContractsController(ContractsService contractsService)
    {
        _contractsService = contractsService;
    }

    [HttpPost("AddContract")]
    public async Task<IActionResult> AddContract([FromBody] ContractVM contract)
    {
        await _contractsService.Create(contract);

        return Ok();
    }

    [HttpGet("GetAllContracts")]
    public async Task<IActionResult> GetAllContracts()
    {
        return Ok(await _contractsService.GetAll());
    }

    [HttpGet("GetContract/{Id}")]
    public async Task<IActionResult> GetContractById(int Id)
    {
        return Ok(await _contractsService.Get(Id));
    }

    [HttpPut("UpdateContract/{Id}")]
    public async Task<IActionResult> UpdateContractById(int Id, [FromBody] ContractVM contract)
    {
        return Ok(await _contractsService.Update(Id, contract));
    }

    [HttpDelete("DeleteContractById/{Id}")]
    public async Task<IActionResult> DeleteContractById(int Id)
    {
        await _contractsService.Delete(Id);
        return Ok();
    }
}
