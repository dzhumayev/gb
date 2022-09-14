int[,] matrix = new int[4, 4];
FillMatrixSpiral(matrix, fillNumber: 20);
PrintMatrix(matrix);


void FillMatrixSpiral(int[,] matrix, int fillNumber)
{
    bool matrixOdd = (matrix.GetLength(0) % 2 != 0);
    int limitOffset = (GetLastRowIndex() / 2);
    int row, col;

    for (int offset = 0; offset <= limitOffset; offset++)
    {
        for (row = offset, col = offset; col < GetLastColIndex() - offset; col++)
        {
            matrix[row, col] = fillNumber++;
        }

        for (col = GetLastColIndex() - offset, row = offset; row < GetLastRowIndex() - offset; row++)
        {
            matrix[row, col] = fillNumber++;
        }

        for (row = GetLastRowIndex() - offset, col = GetLastColIndex() - offset; col > offset; col--)
        {
            matrix[row, col] = fillNumber++;
        }

        for (col = offset, row = GetLastRowIndex() - offset; row > offset; row--)
        {
            matrix[row, col] = fillNumber++;
        }

        if (offset == limitOffset && matrixOdd)
        {
            matrix[offset, offset] = fillNumber;
        }
    }

    int GetLastRowIndex()
    {
        return matrix.GetUpperBound(0);
    }

    int GetLastColIndex()
    {
        return matrix.GetUpperBound(1);
    }
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