using System.Text;

int[] array = new int[6];
FillArrayRandomValues(array, 1, 9);

printArray(array);
System.Console.WriteLine(GetSumOfOddIndex(array));

int GetSumOfOddIndex(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

void FillArrayRandomValues(int[] array, int minValue, int maxValue)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
}

void printArray(int[] array, char delimiter = ' ')
{

    StringBuilder sb = new StringBuilder();
    sb.Append(array[0]);

    for (int i = 1; i < array.Length; i++)
    {
        sb.Append($"{delimiter}{array[i]}");
    }

    System.Console.WriteLine(sb);
}