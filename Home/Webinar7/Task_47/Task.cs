
Console.Write("Введите количество строк: ");
bool colsIsNumber = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool rowsIsNumber = int.TryParse(Console.ReadLine(), out int cols);

if (rowsIsNumber && colsIsNumber)
{
    double[,] array2D = new double[rows, cols];
    FillArrayRandomValues(array2D, 1, 100);
    Print2DArray(array2D);
}
else
{
    PrintWrongMessage();
}

void FillArrayRandomValues(double[,] array2D, int minValue, int maxValue)
{
    Random random = new Random();

    for (int row = 0; row <= array2D.GetUpperBound(0); row++)
    {
        for (int col = 0; col <= array2D.GetUpperBound(1); col++)
        {
            array2D[row, col] = random.Next(minValue, maxValue - 1) + random.NextDouble();
        }
    }
}

void Print2DArray(double[,] array2D)
{
    for (int row = 0; row <= array2D.GetUpperBound(0); row++)
    {
        for (int col = 0; col <= array2D.GetUpperBound(1); col++)
        {
            System.Console.Write($"{array2D[row, col].ToString("00.00")} ");
        }
        System.Console.WriteLine();
    }
}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}