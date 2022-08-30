System.Console.Write("Введите число: ");
bool isIntNumber = int.TryParse(Console.ReadLine(), out int number);

if (isIntNumber)
{
    System.Console.WriteLine(GetSumOfDigits(number));
}
else
{
    System.Console.WriteLine("Некорректный ввод");
}

int GetSumOfDigits(int number)
{
    number = Math.Abs(number);
    int divider = 1;
    int result = 0;

    while (number / divider != 0)
    {
        result += (number / divider) % 10;
        divider *= 10;
    }

    return result;
}



