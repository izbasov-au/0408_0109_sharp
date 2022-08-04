Console.Write("Введите номер дня недели ");
int day = int.Parse(Console.ReadLine());
// string[] mas = {"Пнд", "Втр", "Срд", "Чт"};
// for (int i = 1; i < mas.Length(); i++)
// {
//     if (daynum == i)
//     Console.WriteLine(mas[i+1]);
// }
// //if ( daynum == )
// Math.Abs(daynum);
switch (day)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
        default:
            Console.WriteLine("Ошибка!");
            break;
    }