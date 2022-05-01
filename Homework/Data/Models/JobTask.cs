﻿namespace Homework.Data.Models;

public class JobTask
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int WorkHours { get; set; }
    
    //Navigation properties
    public Employee? Employee { get; set; }
    public int EmployeeId { get; set; }

    public Contract? Contract { get; set; }
    public int ContractId { get; set; }

    public Invoice? Invoice { get; set; }

    public int? InvoiceId { get; set; } = null;

}