using Apbd_3;

var service = new RentalService();
//11
service.addEquipment(new Laptop("Hp", true, "excellent condition", "i7", "RTX 3060"));
service.addEquipment(new Camera("Canon R5", true, "good condition", "Canon RF", 45f));
service.addEquipment(new Projector("Epson EB", true, "good condition", 3000, 1.5f));
//12
var student = new Student("Mateusz","Kowal","Student", "s12411", "Computer science");
var employee = new Employee("Magda","Stolarczyk","Employee", 5000m, "IT");
service.addUser(student);
service.addUser(employee);
//13
var laptop = new Laptop("Dell XPS", true, "good condition", "i7", "RTX 3060");
service.addEquipment(laptop);
var rental = service.rentEquipment(student, laptop, 7);
Console.WriteLine($"Rented {laptop.name} to {student.name} {student.surname}");
//14
try
{
    service.setEquipmentUnavailable(laptop.id);
    service.rentEquipment(student, laptop, 7);
} catch (Exception ex) {
    Console.WriteLine($"Error: {ex.Message}");
}

//15
service.returnEquipment(rental.id);
Console.WriteLine($"Returned {laptop.name} on time");
//16
var camera = new Camera("Canon R5", true, "good condition", "Canon RF" ,45f);
service.addEquipment(camera);
var rental2 = service.rentEquipment(student, camera, 7);
Console.WriteLine($"Penalty for late return: {rental2.penalty} PLN");

rental2.dueDate = DateTime.Now.AddDays(-3);
service.returnEquipment(rental2.id);
Console.WriteLine($"Penalty: {rental2.penalty}");
//17
service.generateReport();
