namespace Apbd_3;

public class Laptop : Equipment
{
    public string processor {get; set;}
    public string GPU {get; set;}

    public Laptop(int id, string name, int availability, string sameData, string processor, string GPU) : base(id, name, availability, sameData)
    {
        this.processor = processor;
        this.GPU = GPU;
    }
}