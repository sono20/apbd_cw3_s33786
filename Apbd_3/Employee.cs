namespace Apbd_3;

public class Employee : Person
{
    public string salary {get; set;}
    public string department {get; set;}

    public Employee(int id, string name, string surname, string userType, string salary, string department) : base(id,
        name, surname, userType)
    {
        this.salary = salary;
        this.department = department;
    }
    
}