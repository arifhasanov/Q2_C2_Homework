namespace Homework.Data.Models;

public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }

    //Navigation properties
    public List<Contract>? Contracts { get; set; }
}