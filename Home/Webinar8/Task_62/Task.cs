
int[,] matrix = new int[4, 4];
Console.WriteLine("Создана матрица 4x4");
FillMatrixSpiral(matrix, startValue: 10);
PrintMatrix(matrix);


void FillMatrixSpiral(int[,] matrix, int startValue)
{
    for (int irow = 0; irow <= GetLastRowIndex(matrix); irow++)
    {
        for (int jcol = 0; jcol < GetLastColIndex(matrix); jcol++)
        {
            matrix[irow, jcol] = startValue++;
        }

        for (int krow = 0; krow < GetLastRowIndex(matrix); krow++)
        {
            matrix[krow, GetLastColIndex(matrix)] = startValue++;
        }

        for (int lcol = GetLastColIndex(matrix); lcol > 0; lcol--)
        {
            matrix[GetLastRowIndex(matrix), lcol] = startValue++;
        }

        for (int mrow = GetLastRowIndex(matrix); mrow > 0; mrow--)
        {
            matrix[mrow, 0] = startValue++;
        }

        break;
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