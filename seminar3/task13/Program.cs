// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите координаты x1: ");
long x1 = long.Parse(Console.ReadLine()!);
Console.Write("Введите координаты y1: ");
long y1 = long.Parse(Console.ReadLine()!);
Console.Write("Введите координаты x2: ");
long x2 = long.Parse(Console.ReadLine()!);
Console.Write("Введите координаты y2: ");
long y2 = long.Parse(Console.ReadLine()!);
long coord1 = calcLength(x1, y1);
long coord2 = calcLength(x2, y2);
double result = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)), 2);
Console.WriteLine($"Расстояние между точками {result}");
long calcLength(long coord1, long coord2)
{
    long res = 0;
    if ((coord1 >= 0) && (coord2 >= 0))
    {
        if (coord1 > coord2)
        {
            res = coord1 - coord2;
        }
        else
        {
            res = coord2 - coord1;
        }
    }
    else if ((coord1 <= 0) && (coord2 <= 0))
    {
        if (coord1 > coord2)
        {
            res = coord1 - coord2;
        }
        else
        {
            res = coord2 - coord1;
        }
    }
    return res;
}