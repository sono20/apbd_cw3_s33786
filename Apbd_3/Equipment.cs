using System.Runtime.CompilerServices;

namespace Apbd_3;

public abstract class Equipment 
{
    private static int _nextId = 1;
    
    public int id { get; set; }
    public string name { get; set; }
    public int availability { get; set; }
    public string commonData {get; set;}

    public Equipment(int id, string name, int availability, string commonData)
    {
        this.id = _nextId++;
        this.name = name;
        this.availability = availability;
        this.commonData = commonData;
        
    }

}