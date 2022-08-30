System.Console.Write("Введите число: ");
bool isIntNumber = int.TryParse(Console.ReadLine(), out int number);
System.Console.Write("Введите степень: ");
bool isIntDegree = int.TryParse(Console.ReadLine(), out int degree);

if (isIntNumber && isIntDegree)
{
    System.Console.WriteLine(CustomPow(number, degree));
}
else
{
    System.Console.WriteLine("Некорректный ввод");
}

int CustomPow(int number, int degree)
{
    int result = 1;

    for (int i = 1; i <= degree; i++)
    {
        result *= number;
    }

    return result;
}


