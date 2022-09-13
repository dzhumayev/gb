
Console.Write("Введите количество строк: ");
bool colsIsInt = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool rowsIsInt = int.TryParse(Console.ReadLine(), out int cols);

if (rowsIsInt && colsIsInt)
{
    int[,] array2D = new int[rows, cols];
    FillArrayRandomValues(array2D, 100, 999);
    Print2DArray(array2D);

    Console.Write("Введите искомое число: ");
    bool numberIsInt = int.TryParse(Console.ReadLine(), out int number);
    if (numberIsInt)
    {
        int[] cell = GetIndexesByValue(array2D, number);
        if (cell[0] >= 0)
        {
            System.Console.WriteLine($"Cell: row {cell[0]} col {cell[1]}");
        }
        else
        {
            System.Console.WriteLine("Элемент отсутствует в матрице");
        }
    }
    else
    {
        PrintWrongMessage();
        return;
    }
}
else
{
    PrintWrongMessage();
}

int[] GetIndexesByValue(int[,] array2D, int number)
{
    int[] result = { -1, -1 };
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (number == array2D[i, j])
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    return result;
}

void FillArrayRandomValues(int[,] array2D, int minValue, int maxValue)
{
    Random random = new Random();

    for (int row = 0; row <= array2D.GetUpperBound(0); row++)
    {
        for (int col = 0; col <= array2D.GetUpperBound(1); col++)
        {
            array2D[row, col] = random.Next(minValue, maxValue);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    for (int row = 0; row <= array2D.GetUpperBound(0); row++)
    {
        for (int col = 0; col <= array2D.GetUpperBound(1); col++)
        {
            System.Console.Write($"{array2D[row, col]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}