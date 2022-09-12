Console.Write("Введите значение b1: ");
bool b1IsNumber = double.TryParse(Console.ReadLine(), out double b1);

Console.Write("Введите значение k1: ");
bool k1IsNumber = double.TryParse(Console.ReadLine(), out double k1);

Console.Write("Введите значение b2: ");
bool b2IsNumber = double.TryParse(Console.ReadLine(), out double b2);

Console.Write("Введите значение k2: ");
bool k2IsNumber = double.TryParse(Console.ReadLine(), out double k2);

if (b1IsNumber && k1IsNumber && b2IsNumber && k2IsNumber)
{
    System.Console.WriteLine(GetIntersectionPointX(b1, b2, k1, k2));
    System.Console.WriteLine(GetIntersectionPointY(b1, b2, k1, k2));
}
else
{
    System.Console.WriteLine("Некорректный ввод");
}

double GetIntersectionPointX(double b1, double b2, double k1, double k2)
{
    return (b2 - b1) / (k1 - k2);
}

double GetIntersectionPointY(double b1, double b2, double k1, double k2)
{
    return k1 * ((b2 - b1) / (k1 - k2)) + b1;
}

