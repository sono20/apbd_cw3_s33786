namespace Apbd_3;

public class Camera : Equipment
{
    public float megaPixels { get; set; }
    public string lensType { get; set; }

    public Camera(int id, string name, int availability, string commonData, string lensType, float megaPixels) : base(id,name,availability,commonData)
    {
        this.lensType = lensType;
        this.megaPixels = megaPixels;
    }
}