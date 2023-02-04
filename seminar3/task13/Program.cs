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
long length = 0;
if ((x1 > 0) && (x2 > 0))
{
    if (x1 > x2)
    {
        length = x1 - x2;
    }
    else
    {
        length = x2 - x1;
    }
}
else if ((x1 < 0) && (x2 < 0))
{
    if (x1 > x2)
    {
        length = x2 - x1;
    }
    else
    {
        length = x1 - x2;
    }

}
long width = 0;
if ((y1 > 0) && (y2 > 0))
{
    if (y1 > y2)
    {
        width = y1 - y2;
    }
    else
    {
        width = y2 - y1;
    }
}
else if ((y1 < 0) && (y2 < 0))
{
    if (y1 > y2)
    {
        width = y2 - y1;
    }
    else
    {
        width = y1 - y2;
    }

}
double result = Math.Round(Math.Sqrt(length * length + width * width), 2);
Console.WriteLine($"Расстояние между точками {result}");