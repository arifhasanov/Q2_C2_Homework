﻿namespace Homework.Data.Models;

public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Contract>? Contracts { get; set; }
}