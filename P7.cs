using System;

class Employee
{
    public virtual void CalculateSalary()
    {
        Console.WriteLine("Employee Salary");
    }
}

class Manager : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Manager Salary: 80000");
    }
}

class Developer : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Developer Salary: 60000");
    }
}

class P7
{
    static void Main()
    {
        Employee manager = new Manager();
        Employee developer = new Developer();

        manager.CalculateSalary();
        developer.CalculateSalary();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}