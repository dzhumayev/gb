System.Console.Write("Введите трёхзначное число: ");
String input = Console.ReadLine();

int secondDigit = getSecondDigit(Convert.ToInt32(input));

System.Console.WriteLine(secondDigit);

int getSecondDigit(int number) {
    return (number % 100) / 10;
}

