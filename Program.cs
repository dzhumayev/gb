Console.Write("Введите число a: ");
int number_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
int number_b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c: ");
int number_c = Convert.ToInt32(Console.ReadLine());

int max = number_a;
if(number_b > max) {
    max = number_b;
}
if(number_c > max) {
    max = number_c;
}

Console.Write($"Максимальное число: {max}");
