using System;
namespace AssetTracker.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string EmailAddress { get; set; } = "";
    public Department? Department { get; set; }
    public override string ToString() => $"{FirstName} {LastName}";
}
