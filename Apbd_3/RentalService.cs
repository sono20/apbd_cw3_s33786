namespace Apbd_3;

public class RentalService
{
    private List<Equipment> _equipments = new List<Equipment>();
    private List<Rental> _rentals = new List<Rental>();
    private List<Person> _users = new List<Person>();

    public void addEquipment(Equipment equipment)
    {
        _equipments.Add(equipment);
    }

    public void addUser(Person user)
    {
        _users.Add(user);
    }

    public List<Equipment> getAllEquipments()
    {
        return _equipments;
    }

    public List<Equipment> GetAvailableEuEquipments()
    {
        List<Equipment> available = new List<Equipment>();
        foreach (var equipment in _equipments)
        {
            if (equipment.availability)
                available.Add(equipment);
        }

        return available;
    }

    public Rental rentEquipment(Person renter, Equipment equipment, int days)
    {
        if (!equipment.availability)
            throw new Exception("Equipment is not available");
        int activeRentals = 0;
        foreach (var r in _rentals)
        {
            if (r.renter.id == renter.id && r.returnDate == null)
                activeRentals++;
        }

        if (activeRentals >= renter.maxRentals)
            throw new Exception($"Rental limit of {renter.maxRentals} reached");

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

        if (rental.returnDate > rental.dueDate)
        {
            int daysLate = (rental.returnDate.Value - rental.dueDate).Days;
            rental.penalty = daysLate * 10m;
        }
    }
    
    public void setEquipmentUnavailable(int equipmentId)
    {
        Equipment equipment = null;
        foreach (var e in _equipments)
        {
            if (e.id == equipmentId)
            {
                equipment = e;
                break;
            }
        }
        if (equipment == null)
            throw new Exception("Equipment not found");
        equipment.availability = false;
    }

    public List<Rental> getRentalsForUser(int userId)
    {
        List<Rental> ongoing = new List<Rental>();
        foreach (var r in _rentals)
        {
            if (r.renter.id == userId)
            {
                ongoing.Add(r);
            }
        }

        if (ongoing.Count == 0)
            Console.WriteLine("No rentals found");

        return ongoing;
    }

    public List<Rental> getOverdueRentals()
    {
        List<Rental> overdue = new List<Rental>();
        foreach (var r in _rentals)
        {
            if (r.returnDate == null && r.dueDate < DateTime.Now)
            { 
                overdue.Add(r);
            }
        }

        if (overdue.Count == 0)
        {
            Console.WriteLine("No rentals found");
        }

        return overdue;
    }

    public void generateReport()
    {
        Console.WriteLine("RENTAL SYSTEM REPORT");
        Console.WriteLine($"Total equipment: {_equipments.Count}");
        int available = 0;
        foreach (var e in _equipments)
        {
            if (e.availability)
                available++;
        }
        Console.WriteLine($"Available equipments: {available}");
        Console.WriteLine($"Available rentals: {_rentals.Count}");

        int active = 0;
        foreach (var r in _rentals)
        {
            if (r.returnDate == null)
                active++;
        }
        Console.WriteLine($"Active rentals: {active}");

        int overdue = 0;
        foreach (var r in _rentals)
        {
            if (r.returnDate == null && r.dueDate < DateTime.Now)
                overdue++;
        }
        Console.WriteLine($"Overdue rentals: {overdue}");
        Console.WriteLine($"Total users: {_users.Count}");
    }
    
    
}