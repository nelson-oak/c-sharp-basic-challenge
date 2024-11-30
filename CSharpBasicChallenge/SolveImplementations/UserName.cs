namespace CSharpBasicChallenge.SolveImplementations;

// Receive user's first and last names and concat it
public class UserName
{
    public static void ShowFullName()
    {
        Console.Write("Type your first name: ");
        var firstName = Console.ReadLine();

        Console.Write("Type your last name: ");
        var lastName = Console.ReadLine();

        if (firstName.Length > 0 && lastName.Length > 0)
        {
            Console.WriteLine($"So, your name is {firstName} {lastName}, right?");
        }
        else
        {
            Console.WriteLine("I need your first name and last name... try again later.");
        }
    }
}
