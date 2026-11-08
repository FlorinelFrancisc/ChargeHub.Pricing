
namespace ChargeHub.Pricing; // Namnområde för projektet

// Klassen AcStation representerar en AC-laddstation
// Den ärver egenskaper och metoder från ChargingStation
public class AcStation : ChargingStation
{
    // Konstruktor som tar emot stationens ID
    public AcStation(string id) : base(id, 11)
    {
        // base skickar ID och 11 kW till basklassens konstruktor
    }

    // Beräknar priset för AC-laddning
    public override decimal CalculatePrice(decimal kwh)
    {
        // Kontrollerar att laddad energi inte är negativ
        if (kwh < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(kwh),
                "Laddad energi får inte vara negativ.");
        }

        // AC-laddning kostar 3,50 kronor per kWh
        return kwh * 3.50m;
    }
}
