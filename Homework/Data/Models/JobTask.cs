namespace Homework.Data.Models;

public class JobTask
{
    public int Id { get; set; }
    public Contract? Contract { get; set; }
    public DateTime Date { get; set; }
    public int WorkHours { get; set; }
    public bool Invoiced { get; set; } = false;
    public Employee? Employee { get; set; }
}