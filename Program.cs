Console.WriteLine("= Zodiac Sign Finder =");
string input;
    while (true)
{
    Console.Write("Please enter your birthday (mm/dd/yyyy): ");
    input = Console.ReadLine()?? string.Empty;

    if (!input.Contains('/'))
    {
        Console.WriteLine("Invalid format. Please use mm/dd/yyyy.");
        continue;
    }
    if (!IsValidInput(input))
    {
        Console.WriteLine("Only digits and '/' are allowed. Try again.");
        continue;
    }
    break;
}
bool IsValidInput(string input)
{
    foreach (char c in input)
    {
        if (!char.IsDigit(c) && c != '/')
        {
            return false;
        }
    }

    return true;
}

string[] parts = input.Split('/');
int month = int.Parse(parts[0]);
int day = int.Parse(parts[1]);
int year = int.Parse(parts[2]);

string zodiac = GetZodiacSign(month, day);
string chineseAnimal = GetChineseZodiac(year);

Console.WriteLine($"\nYour zodiac sign is: {zodiac}");
Console.WriteLine($"Your Chinese zodiac animal is: {chineseAnimal}");

string[] signs = ["Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"];
string[] descriptions =
        [
            "Aries are energetic and natural leaders.",
            "Taurus are patient, reliable, and love comfort.",
            "Gemini are curious, social, and quick thinkers.",
            "Cancer are emotional, intuitive, and caring.",
            "Leo are confident, creative, and charismatic.",
            "Virgo are analytical, detail-oriented, and helpful.",
            "Libra value harmony, balance, and beauty.",
            "Scorpio are intense, passionate, and determined.",
            "Sagittarius love freedom, adventure, and learning.",
            "Capricorn are disciplined, responsible, and ambitious.",
            "Aquarius are independent, innovative, and open-minded.",
            "Pisces are compassionate, imaginative, and artistic."
        ];
 for (int i = 0; i < signs.Length; i++)
        {
            if (signs[i] == zodiac)
            {
                Console.WriteLine("Fun fact: " + descriptions[i]);
                break;
            }
        }

Console.WriteLine("\nThank you for using the Zodiac Finder!");

string GetZodiacSign(int month, int day)
{
    switch (month)
    {
        case 1: // January
            return (day <= 19) ? "Capricorn" : "Aquarius";

        case 2: // February
            return (day <= 18) ? "Aquarius" : "Pisces";

        case 3: // March
            return (day <= 20) ? "Pisces" : "Aries";

        case 4: // April
            return (day <= 19) ? "Aries" : "Taurus";

        case 5: // May
            return (day <= 20) ? "Taurus" : "Gemini";

        case 6: // June
            return (day <= 20) ? "Gemini" : "Cancer";

        case 7: // July
            return (day <= 22) ? "Cancer" : "Leo";

        case 8: // August
            return (day <= 22) ? "Leo" : "Virgo";

        case 9: // September
            return (day <= 22) ? "Virgo" : "Libra";

        case 10: // October
            return (day <= 22) ? "Libra" : "Scorpio";

        case 11: // November
            return (day <= 21) ? "Scorpio" : "Sagittarius";

        case 12: // December
            return (day <= 21) ? "Sagittarius" : "Capricorn";

        default:
            return "Invalid month";
    }
}
string GetChineseZodiac(int year)
{
    string[] animals = ["Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"];
    return animals[(year - 4) % 12];
}