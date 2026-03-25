namespace Apbd_3;

public class Camera : Equipment
{
    public float megaPixels { get; set; }
    public string lensType { get; set; }

    public Camera(string name, bool availability, string commonData, string lensType, float megaPixels) : base(name,availability,commonData)
    {
        this.lensType = lensType;
        this.megaPixels = megaPixels;
    }
}