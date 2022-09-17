Console.Write("Введите число M: ");
bool mIsNumber = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число N: ");
bool nIsNumber = int.TryParse(Console.ReadLine(), out int n);

if (mIsNumber && nIsNumber)
{
    System.Console.WriteLine(GetSumOfSequenseRecursive(m, n));
}
else
{
    PrintWrongMessage();
}

int GetSumOfSequenseRecursive(int m, int n)
{

    if (m == n)
    {
        return m;
    }

    return m + GetSumOfSequenseRecursive(m + 1, n);
}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}