
Console.Write("Введите числа через запятую: ");
string input = Console.ReadLine();
string[] inputSplited = input.Split('s');

if (ValidateAsInt(inputSplited))
{
    int[] numbers = inputSplited.Select(s => int.Parse(s)).ToArray();
    System.Console.WriteLine($"Положительных чисел: {GetPositiveNumbersCount(numbers)}");
}
else
{
    System.Console.WriteLine("Некорректный ввод");
    return;
}

int GetPositiveNumbersCount(int[] numbers)
{
    int count = 0;

    foreach (int e in numbers)
    {
        if (e > 0)
        {
            count++;
        }
    }

    return count;
}

bool ValidateAsInt(string[] array)
{
    foreach (var e in array)
    {
        if (!int.TryParse(e, out int number))
        {
            return false;
        }

    }

    return true;
}
