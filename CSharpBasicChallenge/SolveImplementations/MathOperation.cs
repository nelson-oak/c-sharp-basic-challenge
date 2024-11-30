namespace CSharpBasicChallenge.SolveImplementations;

// Receive two numbers and calc:
// Sum
// Difference
// Multiplication
// Divisão (sim, eu esqueci essa palavra)
// Average
public class MathOperation
{
    public double FirstValue { get; set; }
    public double SecondValue { get; set; }

    public MathOperation(double firstValue, double secondValue)
    {
        FirstValue = firstValue;
        SecondValue = secondValue;
    }

    public double Sum()
    {
        return FirstValue + SecondValue;
    }
    public double Sub()
    {
        return FirstValue - SecondValue;
    }
    public double Multiply()
    {
        return FirstValue * SecondValue;
    }
    public double Divide()
    {
        return FirstValue / SecondValue;
    }
    public double Average()
    {
        return (FirstValue + SecondValue) / 2;
    }
}
