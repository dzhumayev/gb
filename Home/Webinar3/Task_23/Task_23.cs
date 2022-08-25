System.Console.Write("Введите верхнюю границу последовательности: ");
bool IsNumberUpperBorder = int.TryParse(Console.ReadLine(), out int upperBorder);

if (IsNumberUpperBorder)
{
    PrintArrayInConsole(EachNumberInSequencesToCube(upperBorder));
}
else
{
    System.Console.WriteLine("Введено не число");
}

int[] EachNumberInSequencesToCube(int UpperBorder)
{
    int[] array = new int[UpperBorder];

    for (int i = 1; i <= array.Length; i++)
    {
        array[i - 1] = i * i * i;
    }

    return array;
}

void PrintArrayInConsole(int[] array)
{
    foreach (int elem in array)
    {
        System.Console.WriteLine(elem);
    }
}




