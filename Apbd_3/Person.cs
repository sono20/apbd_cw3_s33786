namespace Apbd_3;

public abstract class Person
{
    private static int _nextId = 1;
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string userType { get; set; }

    public Person(string name, string surname, string userType)
    {
        id = _nextId++;
        this.name = name;
        this.surname = surname;
        this.userType = userType;
    }
}