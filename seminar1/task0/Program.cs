﻿// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное на само себя).

// Например:
//  4 -> 16
//  -3 -> 9
//  -7 -> 49 

Console.Clear();
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine()!);
// из консоли приходит символьный (строковый) тип данных, переводим в числовой
int sqr = number * number;
Console.WriteLine("квадрат числа " + number + "равен = " + sqr);
