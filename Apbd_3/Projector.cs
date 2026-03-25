namespace Apbd_3;

public class Projector : Equipment
{
    public int lumens { get; set; }
    public float throwRatio { get; set; }
    public Projector(int id, string name, int availability, string commonData, int lumens, float throwRatio) :base (id, name, availability, commonData)
    {
        this.lumens = lumens;
        this.throwRatio = throwRatio;
    }
}