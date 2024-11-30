using CSharpBasicChallenge.SolveImplementations;

class Program
{
    static void Main()
    {
        int selectedOption = -1;

        do
        {
            Console.WriteLine("======================================================================");
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Welcome user");
            Console.WriteLine("2 - First and last names");
            Console.WriteLine("3 - Math operations");
            Console.WriteLine("4 - Character count");
            Console.WriteLine("5 - Car plate");
            Console.WriteLine("6 - Current date");
            Console.WriteLine("0 - Exit");

            var userInput = Console.ReadLine();

            try
            {
                selectedOption = int.Parse(userInput);
                Console.WriteLine(selectedOption);
            }
            catch
            {
                selectedOption = -1;
                Console.WriteLine("Invalid Input!!!");
                continue;
            }

            Console.Clear();

            switch (selectedOption)
            {
                case 1:
                    {
                        WelcomeUser.ShowWelcomeMessage();
                    }
                    break;
                case 2:
                    {
                        UserName.ShowFullName();
                    }
                    break;
                case 3:
                    {
                        Console.Write("Type a number: ");
                        var inputValue1 = Console.ReadLine();

                        Console.Write("Type another number: ");
                        var inputValue2 = Console.ReadLine();

                        double number1 = 0;
                        double number2 = 0;
                        try
                        {
                            number1 = double.Parse(inputValue1.Replace(".", ","));
                            number2 = double.Parse(inputValue2.Replace(".", ","));
                        }
                        catch
                        {
                            Console.WriteLine("I need two numbers... try again later.");
                            continue;
                        }

                        var mathOperation = new MathOperation(firstValue: number1, secondValue: number2);
                        Console.WriteLine($"{mathOperation.FirstValue} + {mathOperation.SecondValue} = {mathOperation.Sum()}");
                        Console.WriteLine($"{mathOperation.FirstValue} - {mathOperation.SecondValue} = {mathOperation.Sub()}");
                        Console.WriteLine($"{mathOperation.FirstValue} * {mathOperation.SecondValue} = {mathOperation.Multiply()}");
                        Console.WriteLine($"{mathOperation.FirstValue} / {mathOperation.SecondValue} = {mathOperation.Divide()}");
                        Console.WriteLine($"Average of {mathOperation.FirstValue} and {mathOperation.SecondValue}: {mathOperation.Average()}");
                    }
                    break;
                case 4:
                    {
                        StringLength.Count();
                    }
                    break;
                case 5:
                    {
                        Console.Write("Type a number: ");
                        var inputValue = Console.ReadLine();

                        var carPlate = new CarPlate(plate: inputValue);

                        if (carPlate.isLengthValid() && carPlate.isValidDigits())
                        {
                            Console.WriteLine($"{carPlate.Plate} is valid. o/");
                        }
                        else
                        {
                            Console.WriteLine($"{carPlate.Plate} is not a valid plate... please, verify and try again later.");
                        }

                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("TODO...");
                    }
                    break;
                case 0:
                    {
                        Console.WriteLine("Exiting...");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Option not found!!!");
                    }
                    break;
            }
        } while (selectedOption != 0);
    }
}