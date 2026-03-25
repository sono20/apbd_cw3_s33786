namespace Apbd_3;

public class Student : Person
{
    public string indexNumber {get; set;}
    public string fieldOfStudy {get; set;}

    public Student(int id, string name, string surname, string userType, string indexNumber, string fieldOfStudy) :
        base(id, name, surname, userType)
    {
        this.indexNumber = indexNumber;
        this.fieldOfStudy = fieldOfStudy;
    }
}