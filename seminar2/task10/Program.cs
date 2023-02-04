// Напишите программу, которая выводит на экран числа от 1 до 100.
// При этом вместо чисел, кратных трем, программа должна выводить слово "Fizz",
// а вместо чисел кратных 5 слово "Buzz". 
// Если число кратно и 3, и 5 то программа должна выводить слово "FizzBuzz".

Console.Clear();

int count = 1;
while (count <= 100)
{
    if ((count % 3 == 0) & (count % 5 == 0))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("FizzBuzz");
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (count % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Fizz");
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    else if (count % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Buzz");
        Console.ForegroundColor = ConsoleColor.Magenta;
    }
    else
    {
        Console.Write(count);
    }
    if (count == 100)
    {
        Console.Write(". ");
    }
    else
    {
        Console.Write(", ");
    }
    count++;
}