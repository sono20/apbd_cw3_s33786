namespace Apbd_3;

public class Computer : Equipment
{
    public int ramGb { get; set; }
    public int storageGb { get; set; }

    public Computer(int id, string name, int availability, string commonData, int ramGb, int storageGb) : base(id, name,
        availability, commonData)
    {
        this.ramGb = ramGb;
        this.storageGb = storageGb;
    }
}