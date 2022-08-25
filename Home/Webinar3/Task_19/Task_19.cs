System.Console.Write("Введите число: ");
string input = Console.ReadLine();
bool IsNumberInput = int.TryParse(input, out int number);

if (IsNumberInput)
{
    if (input.Length == 5)
    {
        if (IsPolyndrom(input))
        {
            System.Console.WriteLine("Полиндром");
        }
        else
        {
            System.Console.WriteLine("Не полиндром");

        }
    }
    else
    {
        System.Console.WriteLine("Число не пятизначное");
    }
}
else
{
    System.Console.WriteLine("Введено не число");
}

bool IsPolyndrom(string s)
{
    return s.Equals(ReverseString(s));
}

string ReverseString(string s)
{
    char[] array = s.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}

