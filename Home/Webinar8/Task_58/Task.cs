Console.Write("Введите количество строк: ");
bool rowsIsNumber = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов: ");
bool colsIsNumber = int.TryParse(Console.ReadLine(), out int cols);

if (rowsIsNumber && colsIsNumber)
{
    int[,] matrix1 = GetMatrixWithRandomValues(rows, cols, minValue: 1, maxValue: 9);
    PrintMatrix(matrix1);

    System.Console.WriteLine("x");

    int[,] matrix2 = GetMatrixWithRandomValues(cols, rows, minValue: 1, maxValue: 9);
    PrintMatrix(matrix2);

    System.Console.WriteLine("=");

    PrintMatrix(MultiplyMatrices(matrix1, matrix2));
}
else
{
    PrintWrongMessage();
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
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