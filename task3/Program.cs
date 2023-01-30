//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.WriteLine("введите число: ");
int N = int.Parse(Console.ReadLine()); // number = N
int start = -N;
while (start <= N)
{
    Console.Write(start + " ");
    start++;
}