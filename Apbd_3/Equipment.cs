using System.Runtime.CompilerServices;

namespace Apbd_3;

public class Equipment : IEquipment
{
    public int id { get; set; }
    public string name { get; set; }
    public int availability { get; set; }
    public string sameData {get; set;}

    public Equipment(int id, string name, int availability, string sameData)
    {
        id = id;
        name = name;
        availability = availability;
        sameData = sameData;
        
    }

}