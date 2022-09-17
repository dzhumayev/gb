Console.Write("Введите число M: ");
bool mIsNumber = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите число N: ");
bool nIsNumber = int.TryParse(Console.ReadLine(), out int n);

if (mIsNumber && nIsNumber)
{
    PrintMatrix(GetSequenseRecursive(m, n));
}
else
{
    PrintWrongMessage();
}

int[] GetSequenseRecursive(int m, int n)
{
    int[] resultArray = new int[n - m + 1];
    return GetSequenseRecursiveLocal(m, n, resultArray);

    int[] GetSequenseRecursiveLocal(int m, int n, int[] resultArray, int index = 0)
    {
        if (m > n)
        {
            return resultArray;
        }

        resultArray[index] = m;
        return GetSequenseRecursiveLocal(m + 1, n, resultArray, index + 1);
    }
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