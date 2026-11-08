
namespace ChargeHub.Pricing; // Namnområde för projektet

// Klassen DcStation representerar en DC-snabbladdstation
// Den ärver egenskaper och metoder från ChargingStation
public class DcStation : ChargingStation
{
    // Konstruktor som tar emot stationens ID
    public DcStation(string id) : base(id, 150)
    {
        // Skickar ID och maxeffekten 150 kW till basklassen
    }

    // Beräknar priset för DC-laddning
    public override decimal CalculatePrice(decimal kwh)
    {
        // Kontrollerar att laddad energi inte är negativ
        if (kwh < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(kwh),
                "Laddad energi får inte vara negativ.");
        }

        // DC-laddning kostar 5 kr per kWh
        decimal energyPrice = kwh * 5.00m;

        // Startavgiften är 10 kr
        decimal startFee = 10.00m;

        // Returnerar energipriset plus startavgiften
        return energyPrice + startFee;
    }
}
