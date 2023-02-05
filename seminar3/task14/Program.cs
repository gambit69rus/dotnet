// Задача №22. Общее обсуждение
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int counter = 1;
while (counter < number)
{
    Console.WriteLine(counter * counter + ", ");
    counter++;
}
Console.WriteLine(counter * counter + ", ");