using System.Globalization;

namespace CSharpBasicChallenge.SolveImplementations;

// Receive a format (C - Complete, D - DateOnly, H - Hours, M - Month) and show current date.
public class CurrentDate
{
    public static void FormatCurrentDateByInput()
    {
        Console.WriteLine("Type one of these letters to select a format:");
        Console.WriteLine("C - Complete");
        Console.WriteLine("D - DateOnly");
        Console.WriteLine("H - Hours");
        Console.WriteLine("M - Month");
        var input = Console.ReadLine();
        var currentDate = DateTime.Now;

        string? formattedDate;

        switch (input)
        {
            case "C":
            case "c":
                {
                    formattedDate = currentDate.ToString("dddd, MMMM dd, yyyy a\\t hh:mm:ss tt", new CultureInfo("en-US"));
                }
                break;
            case "D":
            case "d":
                {
                    formattedDate = currentDate.ToString("MM/dd/yyyy", new CultureInfo("en-US"));
                }
                break;
            case "H":
            case "h":
                {
                    formattedDate = currentDate.ToString("HH:mm:ss", new CultureInfo("en-US"));
                }
                break;
            case "M":
            case "m":
                {
                    formattedDate = currentDate.ToString("MMMM dd, yyyy", new CultureInfo("en-US"));
                }
                break;
            default:
                {
                    Console.WriteLine("Invalid option... please try again later.");
                    return;
                }
        }

        Console.WriteLine($"It's {formattedDate}!");
    }
}
