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
        if (Plate.Contains('-'))
        {
            if (Plate.Length == 8)
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
        var lettersPart = Plate.Substring(0, 3);
        var startOfNumbersPart = IsWithDash ? 4 : 3;
        var numbersPart = Plate.Substring(startOfNumbersPart);

        if (numbersPart.Length != 4)
        {
            return false;
        }

        try
        {
            int.Parse(numbersPart);
        }
        catch
        {
            return false;
        }

        bool isValid = true;

        foreach(var letter in lettersPart)
        {

            try
            {
                int.Parse(letter.ToString());
                isValid = false;
            }
            catch
            {
                continue;
            }
        }

        return isValid;
    }
}
