namespace Homework.Data.Services;

public class JobTasksService : IService<JobTask, JobTaskVM>
{
    private AppDbContext _context;

    public JobTasksService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<JobTask>> Create(JobTaskVM jobtask)
    {
        var _jobtask = new JobTask()
        {
            Date = jobtask.Date,
            WorkHours = jobtask.WorkHours,
            EmployeeId = jobtask.EmployeeId,
            ContractId = jobtask.ContractId,
            InvoiceId = jobtask.InvoiceId,
        };
        await _context.JobTasks.AddAsync(_jobtask);
        await _context.SaveChangesAsync();
        return await _context.JobTasks.ToListAsync();
    }

    public async Task<IList<JobTask>> GetAll()
    {
        return await _context.JobTasks.ToListAsync();
    }

    public async Task<JobTask> Get(int Id)
    {
        return await _context.JobTasks.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task<JobTask> Update(int Id, JobTaskVM jobtask)
    {
        var _jobtask = await _context.JobTasks.FirstOrDefaultAsync(x => x.Id == Id);
        if (_jobtask != null)
        {
            _jobtask.Date = jobtask.Date;
            _jobtask.WorkHours = jobtask.WorkHours;
            _jobtask.EmployeeId = jobtask.EmployeeId;
            _jobtask.ContractId = jobtask.ContractId;
            _jobtask.InvoiceId = jobtask.InvoiceId;
            _context.SaveChanges();
        }
        return _jobtask;
    }

    public async Task Delete(int Id)
    {
        var _jobtask = await _context.JobTasks.FirstOrDefaultAsync(x => x.Id == Id);
        if (_jobtask != null)
        {
            _context.JobTasks.Remove(_jobtask);
            _context.SaveChangesAsync();
        }
    }
}