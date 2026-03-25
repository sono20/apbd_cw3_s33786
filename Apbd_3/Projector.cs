namespace Apbd_3;

public class Projector : Equipment
{
    public int lumens { get; set; }
    public float throwRatio { get; set; }
    public Projector(string name, bool availability, string commonData, int lumens, float throwRatio) :base (name, availability, commonData)
    {
        this.lumens = lumens;
        this.throwRatio = throwRatio;
    }
}