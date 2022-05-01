namespace Homework.Data.Services;

public class ContractsService : IService<Contract, ContractVM>
{
    private AppDbContext _context;

    public ContractsService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Contract>> Create(ContractVM contract)
    {
        var customer = await _context.Customers.FindAsync(contract.CustomerId);

        var _contract = new Contract()
        {
            Description = contract.Description,
            CustomerId = contract.CustomerId,
            StartDate = contract.StartDate,
            EndDate = contract.EndDate,
            PricePerHour = contract.PricePerHour,
        };
        await _context.Contracts.AddAsync(_contract);
        await _context.SaveChangesAsync();
        return await _context.Contracts.ToListAsync();
    }

    public async Task<IList<Contract>> GetAll()
    {
        return await _context.Contracts.ToListAsync();
    }

    public async Task<Contract> Get(int Id)
    {
        return await _context.Contracts.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task<Contract> Update(int Id, ContractVM contract)
    {
        var _contract = await _context.Contracts.FirstOrDefaultAsync(x => x.Id == Id);
        if (_contract != null)
        {
            _contract.Description = contract.Description;
            _contract.CustomerId = contract.CustomerId;
            _contract.StartDate = contract.StartDate;
            _contract.EndDate = contract.EndDate;
            _contract.PricePerHour = contract.PricePerHour;
            await _context.SaveChangesAsync();
        }
        return _contract;
    }

    public async Task Delete(int Id)
    {
        var _contract = await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);
        if (_contract != null)
        {
            _context.Users.Remove(_contract);
            _context.SaveChangesAsync();
        }
    }
}
