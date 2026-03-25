namespace Apbd_3;

public class Rental
{
    private static int _nextId = 1;
    public int id { get; set; }
    public Person renter { get; set; }
    public Equipment equipment { get; set; }
    public DateTime rentalDate { get; set; }
    public DateTime dueDate { get; set; }
    public DateTime? returnDate { get; set; }

    public Rental(Person renter, Equipment equipment, int days)
    {
        id = _nextId++;
        this.renter = renter;
        this.equipment = equipment;
        rentalDate = DateTime.Now;
        dueDate = DateTime.Now.AddDays(days);
        returnDate = null;
    }
}