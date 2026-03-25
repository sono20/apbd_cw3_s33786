namespace Apbd_3;

public interface IRentable
{
    bool isAvailable { get; set; }
    void Rent();
    void Return();
}