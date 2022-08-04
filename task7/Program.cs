Console.WriteLine("Введите 3-х значное число: ");
int a = int.Parse(Console.ReadLine());
if (a < 0){
    Console.WriteLine($"Крайняя цифра введенного числа: {a * -1 % 10}");
}
else {
    Console.WriteLine($"Крайняя цифра введенного числа: {a % 10}");
}