using System.Text;

int[] array = new int[5];
FillArrayRandomValues(array, 100, 999);

printArray(array);
System.Console.WriteLine(GetEvenCount(array));

int GetEvenCount(int[] array)
{
    int count = 0;

    foreach(var elem in array){
        if (elem % 2 == 0)
        {
            count++;
        }
    }

    return count;
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