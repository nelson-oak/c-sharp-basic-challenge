namespace CSharpBasicChallenge.SolveImplementations;

// Receive a string and count characters
public class StringLength
{
    public static void Count()
    {
        Console.WriteLine("Type a text (press enter to send):");
        var someText = Console.ReadLine();

        Console.WriteLine($"Wow... so you've typed {someText.Length} characters!");
    }
}
