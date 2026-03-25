namespace Apbd_3;

public class Rental
{
    public int id { get; set; }
    public Person renter { get; set; }
    public Equipment equipment { get; set; }
    public DateTime renatlDate { get; set; }
    public DateTime dueDate { get; set; }
    public DateTime? returnDate { get; set; }
    
    
}