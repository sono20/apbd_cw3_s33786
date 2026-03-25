namespace Apbd_3;

public abstract class Person
{
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string userType { get; set; }

    public Person(int id, string name, string surname, string userType)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.userType = userType;
    }
}