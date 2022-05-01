namespace Homework.Data.Services;

public class EmployeesService : IService<Employee, EmployeeVM>
{
    private AppDbContext _context;

    public EmployeesService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Employee>> Create(EmployeeVM employee)
    {
        var _employee = new Employee()
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
        };
        await _context.Employees.AddAsync(_employee);
        await _context.SaveChangesAsync();
        return await _context.Employees.ToListAsync();
    }

    public async Task<IList<Employee>> GetAll()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee> Get(int Id)
    {
        return await _context.Employees.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task<Employee> Update(int Id, EmployeeVM employee)
    {
        var _employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == Id);
        if (_employee != null)
        {
            _employee.FirstName = employee.FirstName;
            _employee.LastName = employee.LastName;
            _context.SaveChanges();
        }
        return _employee;
    }

    public async Task Delete(int Id)
    {
        var _employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == Id);
        if (_employee != null)
        {
            _context.Employees.Remove(_employee);
            _context.SaveChangesAsync();
        }
    }
}
