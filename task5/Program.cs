Console.WriteLine("Введите целое положит. число: ");
int a = int.Parse(Console.ReadLine());
for(int i = -a; i <= a; i++)
{
    Console.Write(i + " ");
}