namespace Homework.Data.Models;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    //Navigation properties
    public List<JobTask>? JobTask { get; set; }
}
