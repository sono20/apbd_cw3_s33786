namespace Apbd_3;

public class Employee : Person
{
    public override int maxRentals
    {
        get => 5;
    }
    public decimal salary {get; set;}
    public string department {get; set;}

    public Employee(string name, string surname, string userType, decimal salary, string department) : base(name, surname, userType)
    {
        this.salary = salary;
        this.department = department;
    }
    
}