Console.Write("Введите количество строк мартицы: ");
bool rowsIsNumber = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов матрицы: ");
bool colsIsNumber = int.TryParse(Console.ReadLine(), out int cols);
Console.Write("Задайте глубину матрицы матрицы: ");
bool depthIsNumber = int.TryParse(Console.ReadLine(), out int depth);

if (rowsIsNumber && colsIsNumber && depthIsNumber)
{
    int[,,] matrix3D = new int[rows, cols, depth];
    FillMatrix3DIncremented(matrix3D, startValue: 11);
    PrintMatrix3DWithIndexes(matrix3D);
}
else
{
    PrintWrongMessage();
}


void FillMatrix3DIncremented(int[,,] matrix3D, int startValue)
{
    int number = startValue;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = number++;
            }
        }
    }
}

void PrintMatrix3DWithIndexes(int[,,] matrix3D)
{
    string message;

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                message = $"{matrix3D[i, j, k]}({i}, {j}, {k})";
                if (k == 0)
                {
                    System.Console.Write(message);
                }
                else
                {
                    System.Console.Write($" {message}");

                }
            }
            System.Console.Write("    ");
        }
        System.Console.WriteLine();
    }

}

void PrintWrongMessage()
{
    System.Console.WriteLine("Некорректный ввод");
}