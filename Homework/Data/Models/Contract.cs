namespace Homework.Data.Models;
public class Contract
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Decimal PricePerHour { get; set; } = 50;

    //Navigation properties
    public Customer? Customer { get; set; }
    public int CustomerId { get; set; }
    public List<JobTask>? JobTasks { get; set; }
}
