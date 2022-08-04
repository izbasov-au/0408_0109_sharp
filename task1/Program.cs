//task1
Console.Write("Введите два целых числа: ");
int a = int.Parse(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}