int[,] matrix = new int[4, 4];
FillMatrixSpiral(matrix, fillNumber: 20);
PrintMatrix(matrix);


void FillMatrixSpiral(int[,] matrix, int fillNumber)
{
    bool matrixOdd = (matrix.GetLength(0) / 2 != 0);
    int limitOffset = (GetLastRowIndex(matrix) / 2);

    for (int offset = 0; offset <= limitOffset; offset++)
    {
        for (int row = offset; row == offset;)
        {
            for (int col = offset; col < GetLastColIndex(matrix) - offset; col++)
            {
                matrix[row, col] = fillNumber++;
            }
            break;
        }

        for (int col = (GetLastColIndex(matrix) - offset); col == (GetLastColIndex(matrix) - offset);)
        {
            for (int row = offset; row < GetLastRowIndex(matrix) - offset; row++)
            {
                matrix[row, col] = fillNumber++;
            }
            break;
        }

        for (int row = (GetLastRowIndex(matrix) - offset); row == (GetLastRowIndex(matrix) - offset);)
        {
            for (int col = GetLastColIndex(matrix) - offset; col > offset; col--)
            {
                matrix[row, col] = fillNumber++;
            }
            break;
        }

        for (int col = offset; col == offset;)
        {
            for (int row = GetLastRowIndex(matrix) - offset; row > offset; row--)
            {
                matrix[row, col] = fillNumber++;
            }
            break;
        }

        if (offset == limitOffset && matrixOdd)
        {
            matrix[offset, offset] = fillNumber;
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