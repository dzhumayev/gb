
Console.Write("Введите количество строк: ");
bool colsIsInt = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool rowsIsInt = int.TryParse(Console.ReadLine(), out int cols);

if (rowsIsInt && colsIsInt)
{
    int[,] array2D = new int[rows, cols];
    FillArrayRandomValues(array2D, 100, 999);
    Print2DArray(array2D);

    System.Console.WriteLine("------------------------------------------------------------------------");

    PrintArray(GetAveragesByCols(array2D));
}
else
{
    PrintWrongMessage();
}

double[] GetAveragesByCols(int[,] array2D)
{
    double[] resultArray = new double[array2D.GetLength(1)];
    double sumByCol = 0.0;

    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            sumByCol+=array2D[i,j];
        }

        resultArray[j] = sumByCol / array2D.GetLength(0);
        sumByCol = 0.0;
    }

    return resultArray;
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

void PrintArray(double[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($" {array[i].ToString("00.00")}");
    }
}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}