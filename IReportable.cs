
namespace ChargeHub.Pricing; // Namnområde för projektet

// Interface som används för att skapa rapporter
public interface IReportable
{
    // Alla klasser som implementerar interfacet
    // måste ha en metod som heter GetReport
    // Metoden ska returnera en text (string)
    string GetReport();
}
