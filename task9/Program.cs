// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10, 100);
//Console.WriteLine($"Случайное число от 10 до 99: {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// 1 variant
// if (firstDigit == secondDigit) {
//     Console.WriteLine($"Цифры равны: {firstDigit}");
// }
// else if (firstDigit > secondDigit) {
//     Console.WriteLine($"Max {number}: {firstDigit}");
// }
// else {
//     Console.WriteLine($"Max {number}: {secondDigit}");
// }

// 2 variant
// string result = firstDigit == secondDigit ? "Цифры равны:" 
// : firstDigit > secondDigit ? firstDigit.ToString() : secondDigit.ToString();
// Console.WriteLine($"Max {number}: {result}");  10 13 15

// 3 variant - method
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(number);
int result2 = MaxDigit(44);

string res = result == 0 ? "Цифры равны:" : result.ToString();
Console.WriteLine($"Max {number}: {res}");

string res2 = result2 == 0 ? "Цифры равны:" : result2.ToString();
Console.WriteLine($"Max {44}: {res2}");
