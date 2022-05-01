namespace Homework.Data.Services;

public class CustomersService : IService<Customer, CustomerVM>
{
    private AppDbContext _context;

    public CustomersService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Customer>> Create(CustomerVM customer)
    {
        var _customer = new Customer()
        {
            Name = customer.Name,
        };
        await _context.Customers.AddAsync(_customer);
        await _context.SaveChangesAsync();
        return await _context.Customers.ToListAsync();
    }

    public async Task<IList<Customer>> GetAll()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<Customer> Get(int Id)
    {
        return await _context.Customers.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task<Customer> Update(int Id, CustomerVM customer)
    {
        var _customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == Id);
        if (_customer != null)
        {
            _customer.Name = customer.Name;
            _context.SaveChanges();
        }
        return _customer;
    }

    public async Task Delete(int Id)
    {
        var _customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == Id);
        if (_customer != null)
        {
            _context.Customers.Remove(_customer);
            _context.SaveChangesAsync();
        }
    }
}
