System.Console.Write("Введите ax: ");
bool IsNumberAx = int.TryParse(Console.ReadLine(), out int ax);
System.Console.Write("Введите ay: ");
bool IsNumberAy = int.TryParse(Console.ReadLine(), out int ay);
System.Console.Write("Введите az: ");
bool IsNumberAz = int.TryParse(Console.ReadLine(), out int az);

System.Console.Write("Введите bx: ");
bool IsNumberBx = int.TryParse(Console.ReadLine(), out int bx);
System.Console.Write("Введите by: ");
bool IsNumberBy = int.TryParse(Console.ReadLine(), out int by);
System.Console.Write("Введите bz: ");
bool IsNumberBz = int.TryParse(Console.ReadLine(), out int bz);

if (IsNumberAx && IsNumberAy && IsNumberAz && IsNumberBx && IsNumberBy && IsNumberBz)
{
    System.Console.WriteLine(GetLengthIn3DSpace(ay, ay, az, bx, by, bz));
}
else
{
    System.Console.WriteLine("Введены некоректные данные");
}

double GetLengthIn3DSpace(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
}




