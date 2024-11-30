namespace CSharpBasicChallenge.SolveImplementations;

// Receive user's name by console
// Show the message Hello, {user}! How can I help you?
public class WelcomeUser
{
    public static void ShowWelcomeMessage()
    {
        Console.Write("Type your name: ");
        var userName = Console.ReadLine();

        if (userName.Length > 0)
        {
            Console.WriteLine($"Hello, {userName}! How can I help you?");
        }
        else
        {
            Console.WriteLine("I need your name to say hello... try again later.");
        }
    }
}
