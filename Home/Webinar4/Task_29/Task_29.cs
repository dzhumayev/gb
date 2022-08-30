System.Console.Write("Введите элементы массива через запятую: ");
string input = Console.ReadLine();

if(input.Trim() != "")
{
    printArray(ConvertStringToArray(input));
}
else
{
    System.Console.WriteLine("Некорректный ввод");
}

string[] ConvertStringToArray(string str)
{
    return str.Split(',');
}

void printArray(string[] array)
{
    foreach (string item in array)
    {
        System.Console.WriteLine(item);
    }
}