namespace Homework.Data.ViewModels;

public class JobTaskVM
{
    public DateTime Date { get; set; }
    public int WorkHours { get; set; }

    //Navigation properties
    public int EmployeeId { get; set; }
    public int ContractId { get; set; }
    public int? InvoiceId { get; set; } = null;
}
