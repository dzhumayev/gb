Console.Write("Введите число M: ");
bool mIsNumber = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число N: ");
bool nIsNumber = int.TryParse(Console.ReadLine(), out int n);

if (mIsNumber && nIsNumber)
{
    System.Console.WriteLine(Ackerman(m, n));
}
else
{
    PrintWrongMessage();
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ackerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    else
        return n + 1;
}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}