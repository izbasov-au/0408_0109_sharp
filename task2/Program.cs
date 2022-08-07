// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите два целых числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max, min;
if (a > b) {
    max = a;
    min = b;
    
}
else {
    max = b;
    min = a;
}
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");