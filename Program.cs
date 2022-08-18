// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Введите число a: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int number_b = Convert.ToInt32(Console.ReadLine());


if(number_a > number_b) {
    Console.WriteLine($"Большее a: {number_a}");
    Console.WriteLine($"Меньшее: b {number_b}");
}
else if(number_b > number_a) {
    Console.WriteLine($"Большее b: {number_b}");
    Console.WriteLine($"Меньшее a: {number_a}");
}
else {
    Console.WriteLine("Числа равны");
}