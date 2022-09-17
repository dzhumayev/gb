Console.Write("Введите число M: ");
bool mNumberIsNumber = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число M: ");
bool nNumberIsNumber = int.TryParse(Console.ReadLine(), out int n);

if (mNumberIsNumber && nNumberIsNumber)
{
    PrintMatrix(GetSequenseRecursive(m, n, new int[n - m + 1]));
}
else
{
    PrintWrongMessage();
}

int[] GetSequenseRecursive(int m, int n, int[] resultArray, int index = 0)
{

    if (m > n)
    {
        return resultArray;
    }

    resultArray[index] = m;
    return GetSequenseRecursive(m + 1, n, resultArray, index + 1);
}

void PrintMatrix(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}