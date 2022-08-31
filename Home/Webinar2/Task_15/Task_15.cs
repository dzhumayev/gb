System.Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7) {
    if (IsHoliday(number)) {
        System.Console.WriteLine($"День {number} - выходной");
    }
    else {
        System.Console.WriteLine($"День {number} - будний");
    }
} 
else {
    System.Console.WriteLine($"День {number} - не существует");
}

bool IsHoliday(int number) {
    return number switch {
        6 => true,
        7 => true,
        _ => false
    };
}