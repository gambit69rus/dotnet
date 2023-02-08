// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"произведение чисел = {GetMulNums(num)}");

int GetMulNums(int number)
{
    int temp = 1;
    for (int count = 1; count <= number; count++)
    {
        temp = temp * count;
    }
    return temp;
}