namespace BasicPrograms.Interview;
public class NumberTeller
{
    private static readonly Dictionary<int, string> ones = new ()
    {
        { 0, "Zero" },
        {1, "One" },
        {2, "Two" },
        {3, "Three" },
        {4, "Four" },
        {5, "Five" },
        {6, "Six" },
        {7, "Seven" },
        {8, "Eight" },
        {9, "Nine" }
    };

    private static readonly Dictionary<int, string> oneOnes = new ()
    {
        {1, "Eleven" },
        {2, "Twelve" },
        {3, "Thirteen" },
        {4, "Fourteen" },
        {5, "Fifteen" },
        {6, "Sixteen" },
        {7, "Seventeen" },
        {8, "Eighteen" },
        {9, "Nineteen" }
    };

    private static readonly Dictionary<int, string> tens = new ()
    {
        {2, "Twenty" },
        {3, "Thirty" },
        {4, "Fourty" },
        {5, "Fifty" },
        {6, "Sixty" },
        {7, "Seven" },
        {8, "Eighty" },
        {9, "Ninty" }
    };

    private const int ten = 10;
    private const int hundred = 100;
    private const int thousand = 1000;
    private const int lakh = 100000;
    public static string EnterNumber(int number)
    {
        if (number > 999)
        {
            return "Enter valid number";
        }
        else
        {
            return TellNumber(number);
        }
    }

    public static string TellNumber(int number)
    {
        var result = string.Empty;
        result += PrintThousands(number % lakh);
        result += PrintHundreds(number % thousand);
        result += PrintDigits(number % hundred);
        result += PrintDigits(number % ten);

        return result;
    }

    private static string PrintLakhs(int number)
    {
        if (number < lakh)
        {
            return "";
        }
        return PrintDigits(number / thousand) + "lakhs ";
    }

    private static string PrintThousands(int number)
    {
        if (number < thousand)
        {
            return "";
        }
        return PrintDigits(number / thousand) + "Thousand ";
    }

    private static string PrintHundreds(int number)
    {
        if (number < hundred)
        {
            return "";
        }
        return PrintDigits(number / hundred) + "Hundred ";
    }
    private static string PrintTens(int number)
    {
        if (number < ten)
        {
            return "";
        }
        return "";
    }

    private static string PrintDigits(int number)
    {
        var result = string.Empty;
        if (IsLastZero(number))
        {
            return "";
        }
        var multiplier = Multiplier(number);
        var firstDigit = number / multiplier;

        switch (number.ToString().Length)
        {
            case 2:
                if (firstDigit == 1)
                {
                    return oneOnes[number % multiplier];
                }
                else
                {
                    return tens[firstDigit] + " ";
                }
            case 1:
                return ones[firstDigit] + " ";
            default:
                return "";
        }
    }

    public static bool IsLastZero(int number)
    {
        return number.ToString().Length == 1 && number == 0;
    }

    public static int Multiplier(int number)
    {
        return (int)Math.Pow(10, (number.ToString().Length - 1));
    }

}
