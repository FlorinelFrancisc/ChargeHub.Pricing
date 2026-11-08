
namespace ChargeHub.Pricing; // Namnområde för projektet

// Abstrakt basklass för alla typer av laddstationer
public abstract class ChargingStation
{
    // Laddstationens unika identifierare
    public string Id { get; }

    // Laddstationens maximala effekt i kW
    public int MaxKw { get; }

    // Protected konstruktor - används av klasser som ärver
    protected ChargingStation(string id, int maxKw)
    {
        // Sparar stationens identifierare
        Id = id;

        // Sparar stationens maximala effekt
        MaxKw = maxKw;
    }

    // Abstrakt metod som underklasser måste implementera
    // Tar emot laddad energi i kWh och returnerar priset i kronor
    public abstract decimal CalculatePrice(decimal kwh);
}
