
int[,] matrix = new int[4, 4];
Console.WriteLine("Создана матрица 4x4");
FillMatrixSpiral(matrix, startValue: 20);
PrintMatrix(matrix);


void FillMatrixSpiral(int[,] matrix, int startValue)
{
    for (int offset = 0; offset <= GetLastRowIndex(matrix) / 2; offset++)
    {
        for (int row = offset; row == offset;)
        {
            for (int col = 0 + offset; col < GetLastColIndex(matrix) - offset; col++)
            {
                matrix[row, col] = startValue++;
            }
            break;
        }

        for (int col = (GetLastColIndex(matrix) - offset); col == (GetLastColIndex(matrix) - offset);)
        {
            for (int row = 0 + offset; row < GetLastRowIndex(matrix); row++)
            {
                matrix[row, col] = startValue++;
            }
            break;
        }

        for (int row = (GetLastRowIndex(matrix) - offset); row == (GetLastRowIndex(matrix) - offset);)
        {
            for (int col = GetLastColIndex(matrix) - offset; col > (0 + offset); col--)
            {
                matrix[row, col] = startValue++;
            }
            break;
        }

        for (int col = (0 + offset); col == (0 + offset);)
        {
            for (int row = GetLastRowIndex(matrix) - offset; row > 0 + offset; row--)
            {
                matrix[row, col] = startValue++;
            }
            break;
        }
    }
}

int GetLastRowIndex(int[,] matrix)
{
    return matrix.GetUpperBound(0);
}

int GetLastColIndex(int[,] matrix)
{
    return matrix.GetUpperBound(1);
}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row <= matrix.GetUpperBound(0); row++)
    {
        for (int col = 0; col <= matrix.GetUpperBound(1); col++)
        {
            System.Console.Write($"{matrix[row, col]} ");
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