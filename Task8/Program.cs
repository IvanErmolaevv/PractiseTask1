//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);
int num = 2;

if (num <= N)
{
    while (num <= N)
    {
        Console.Write(num);
        if (num <= N - 2)
        {
            Console.Write(", ");
        }
        num++;
        num++;
    }
    Console.WriteLine(".");
}
else
{
    Console.WriteLine("Число должно быть больше 1");
}