
namespace Apbd_3;

public abstract class Equipment 
{
    private static int _nextId = 1;
    
    public int id { get; set; }
    public string name { get; set; }
    public bool availability { get; set; }
    public string commonData {get; set;}

    public Equipment(string name, bool availability, string commonData)
    {
        id = _nextId++;
        this.name = name;
        this.availability = availability;
        this.commonData = commonData;
        
    }
    
    
    public void Rent() => availability = false;
    public void Return() => availability = true;

}