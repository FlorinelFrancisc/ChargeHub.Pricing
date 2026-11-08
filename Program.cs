
using ChargeHub.Pricing; // Gör att vi kan använda projektets klasser

// Skapar en bil med ID 1, batteri på 75 kWh och 0 % laddning
Vehicle car = new Vehicle("1", 75, 0);

// Skapar en AC-laddstation med ID AC-01 och maxeffekt 11 kW
AcStation acStation = new AcStation("AC-01");

// Skapar en DC-laddstation med ID DC-01 och maxeffekt 150 kW
DcStation dcStation = new DcStation("DC-01");

// Skapar en lista med objekt som implementerar IReportable
List<IReportable> reports = new List<IReportable>
{
    car,       // Bilen
    acStation, // AC-laddstationen
    dcStation  // DC-laddstationen
};

// Går igenom alla objekt i listan
foreach (IReportable item in reports)
{
    // Anropar GetReport och skriver ut resultatet
    Console.WriteLine(item.GetReport());
}
