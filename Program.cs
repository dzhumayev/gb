﻿System.Console.Write("Введите число: ");
String input = Console.ReadLine();

if (input.Length > 2) {
    int thirdDigit = getThirdDigit(Convert.ToInt32(input));
    System.Console.WriteLine(thirdDigit);
} else {
    System.Console.WriteLine("Третьей цифры нет.");
}

int getThirdDigit(int number) {
    return Convert.ToInt32(number.ToString().Substring(2, 1));
}

