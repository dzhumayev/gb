using System.Text;

double[] array = new double[6];
FillArrayRandomValues(array, 1, 99);

printArray(array);
System.Console.WriteLine(GetDiffBetweenMaxMin(array));

double GetDiffBetweenMaxMin(double[] array)
{
    return Max(array) - Min(array);
}

double Min(double[] array)
{
    double min = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        min = (array[i] < min) ? array[i] : min;
    }

    return min;
}

double Max(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        max = (array[i] > max) ? array[i] : max;
    }

    return max;
}

void FillArrayRandomValues(double[] array, int minValue, int maxValue)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue) + random.NextDouble();
    }
}

void printArray(double[] array, char delimiter = ' ')
{

    StringBuilder sb = new StringBuilder();
    sb.Append(array[0]);

    for (int i = 1; i < array.Length; i++)
    {
        sb.Append($"{delimiter}{array[i]}");
    }

    System.Console.WriteLine(sb);
}