namespace Homework.Models;

public class Invoice
{
    public int Id { get; set; } 
    public List<Task>? Tasks { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public DateTime InvoiceDate { get; set; }
    public bool IsPaid { get; set; } = false;
}
