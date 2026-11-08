
namespace ChargeHub.Pricing; // Namnområde för projektet

// Klassen Vehicle representerar en elbil

public class Vehicle : IReportable
{
    // Bilens unika identifierare
    public string Id { get; }

    // Sparar bilens batteriprocent
    private double _percent;

    // Batteriprocenten får endast vara mellan 0 och 100
    public double Percent
    {
        get { return _percent; }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Batteriprocent måste vara mellan 0 och 100.");
            }

            _percent = value;
        }
    }

    // Batteriets totala kapacitet i kWh
    public double BatteryKWh { get; }

    // Konstruktor som körs när vi skapar en ny bil
    public Vehicle(string id, double batteryKWh, double percent)
    {
        // Sparar bilens identifierare
        Id = id;

        // Kontrollera att batterikapaciteten är större än 0
        if (batteryKWh <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(batteryKWh),
                "Batterikapaciteten måste vara större än 0 kWh.");
        }

        // Sparar batteriets kapacitet
        BatteryKWh = batteryKWh;

        // Sparar batteriprocenten (kontrolleras av private set)
        Percent = percent;
    }

    // Laddar bilens batteri med ett antal kWh
    public void Charge(double kwh)
    {
        // Kontrollera att energin är större än 0
        if (kwh <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(kwh),
                "Laddningen måste vara större än 0 kWh.");
        }

        // Räkna om kWh till procent av batteriets kapacitet
        double addedPercent = (kwh / BatteryKWh) * 100;

        // Öka laddningen, men aldrig över 100 procent
        Percent = Math.Min(100, Percent + addedPercent);
    }

    // Skapar en rapport med bilens ID och batteriprocent
    public string GetReport()
    {
        // Returnerar bilens information som en text
        return $"Bil {Id}: {Percent} %";
    }

}


