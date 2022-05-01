namespace Homework.Data.ViewModels;

public class InvoiceVM
{
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public DateTime InvoiceDate { get; set; }
    public bool IsPaid { get; set; } = false;

    //Navigation properties
    public List<JobTask>? JobTasks { get; set; }
}
