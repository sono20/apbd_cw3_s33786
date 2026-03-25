namespace Apbd_3;

public class Laptop : Equipment
{
    public string processor {get; set;}
    public string GPU {get; set;}

    public Laptop(string name, bool availability, string sameData, string processor, string GPU) : base(name, availability, sameData)
    {
        this.processor = processor;
        this.GPU = GPU;
    }
}