// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();
Console.WriteLine("Введите число 1 ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2 ");
int number2 = int.Parse(Console.ReadLine());
// int sqr = number2*number2;
if(number1 == number2*number2)
    {
     Console.Write (number1 + "является квадратом" + number2);
    }
    
else
{
 Console.Write (number1 + "не является квадратом" + number2);
}
