namespace CSharpBasicChallenge.SolveImplementations;

// receive a string and verify if it is a valid car plate (abc-1234)
public class CarPlate
{
    public string Plate { get; set; }
    private bool IsWithDash = false;
    public CarPlate(string plate)
    {
        Plate = plate.Trim();
    }

    public bool isLengthValid()
    {
        if (Plate.Length == 9)
        {
            if (Plate.Contains('-'))
            {
                IsWithDash = true;
                return true;
            }
            return false;
        }

        return Plate.Length == 7;
    }

    public bool isValidDigits()
    {
        // TODO
        return true;
    }
}
