namespace Homework.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Contract>? Contracts  { get; set; }
    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Invoice>? Invoices { get; set; }
    public DbSet<JobTask>? JobTasks { get; set; }
    public DbSet<User>? Users { get; set; }

}
