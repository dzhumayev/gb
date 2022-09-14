Console.Write("Введите количество строк: ");
bool rowsIsNumber = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool colsIsNumber = int.TryParse(Console.ReadLine(), out int cols);

if (rowsIsNumber && colsIsNumber)
{
    int[,] matrix = GetMatrixWithRandomValues(rows, cols, minValue: 1, maxValue: 9);
    PrintMatrix(matrix);

    System.Console.WriteLine(new string('-', 50));

    System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {GetRowIndexWithMinSum(matrix)}");
}
else
{
    PrintWrongMessage();
}

int GetRowIndexWithMinSum(int[,] matrix)
{
    int minSum = GetSumByRow(matrix, 0);
    int currentMinSum;
    int resultRowIndex = 0;

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        currentMinSum = GetSumByRow(matrix, i);
        if (currentMinSum < minSum)
        {
            minSum = currentMinSum;
            resultRowIndex = i;
        }
    }

    return resultRowIndex;
}

int GetSumByRow(int[,] matrix, int row)
{
    int sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[row, j];
    }

    return sum;
}

int[,] GetMatrixWithRandomValues(int rows, int cols, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, cols];
    FillMatrixRandomValues(resultMatrix, minValue, maxValue);
    return resultMatrix;
}

void FillMatrixRandomValues(int[,] matrix, int minValue, int maxValue)
{
    Random random = new Random();

    for (int row = 0; row <= matrix.GetUpperBound(0); row++)
    {
        for (int col = 0; col <= matrix.GetUpperBound(1); col++)
        {
            matrix[row, col] = random.Next(minValue, maxValue);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    System.Console.Write(matrix[0, 0]);
    for (int row = 0; row <= matrix.GetUpperBound(0); row++)
    {
        for (int col = 0; col <= matrix.GetUpperBound(1); col++)
        {
            if (row == 0 && col == 0)
            {
                continue;
            }
            if (col == 0)
            {
                System.Console.Write($"{matrix[row, col]}");
            }
            else
            {
                System.Console.Write($" {matrix[row, col]}");
            }
        }
        System.Console.WriteLine();
    }
}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}