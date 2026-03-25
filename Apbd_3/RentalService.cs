namespace Apbd_3;

public class RentalService
{
    private List<Rental> _rentals = new List<Rental>();

    public Rental rentEquipment(Person renter, Equipment equipment, int days)
    {
        if (!equipment.IsAvailable)
            throw new Exception("Equipment is not available");
        
        equipment.Rent();
        var rental = new Rental(renter, equipment, days);
        _rentals.Add(rental);
        return rental;
    }
    public void returnEquipment(int rentalId)
    {
        Rental rental = null;
        foreach (var r in _rentals)
        {
            if (r.id == rentalId)
            {
                rental = r;
                break;
            }
        }
    
        if (rental == null)
            throw new Exception("Rental not found");

        rental.returnDate = DateTime.Now;
        rental.equipment.Return();
    }
}