
Console.Write("Введите количество строк: ");
bool colsIsNumber = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool rowsIsNumber = int.TryParse(Console.ReadLine(), out int cols);

if (rowsIsNumber && colsIsNumber)
{
    int[,] matrix = GetMatrixWithRandomValues(rows, cols, minValue: 10, maxValue: 99);
    PrintMatrix(matrix);

    System.Console.WriteLine(new string('-', 50));

    SortRowsDescending(matrix);
    PrintMatrix(matrix);
}
else
{
    PrintWrongMessage();
}

void SortRowsDescending(int[,] matrix)
{
    int temp;

    for (int i = 0; i <= matrix.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= matrix.GetUpperBound(1) - 1; j++)
        {
            for (int k = 0; k <= matrix.GetUpperBound(1) - 1 - j; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }

        }
    }
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