// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    Console.WriteLine(number.ToString()[2]);
}
else {
    Console.WriteLine("третьей цифры нет");
}

