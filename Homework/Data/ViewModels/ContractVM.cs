namespace Homework.Data.ViewModels;

public class ContractVM
{
    public string? Description { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public Decimal PricePerHour { get; set; } = 50;
    public int CustomerId { get; set; }
}
