System.Console.Write("Введите трёхзначное число: ");
String input = Console.ReadLine();

int secondDigit = GetSecondDigit(Convert.ToInt32(input));

System.Console.WriteLine(secondDigit);

int GetSecondDigit(int number) {
    return (number % 100) / 10;
}