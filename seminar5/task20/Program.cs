// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int size = InputNumber("Введите размер массива");
int min = InputNumber("Введите минимальное значение в массиве");
int max = InputNumber("Введите максимальное значение в массиве");
int num = InputNumber("Введите число которое нужно найти в массиве");
int[] array = GetArray(size, min, max);
PrintArray(array);
Console.Write($"число {num} в массиве ");
if (CheckArrayNum(array, num)) Console.WriteLine("присутствует");
else Console.WriteLine("отсутствует");
bool CheckArrayNum(int[] someArray, int checkNum)
{
    bool flag = false;
    for (int i = 0; i <= someArray.Length - 1; i++) if (someArray[i] == checkNum) flag = true;
    return flag;
}

int[] GetArray(int length, int min = -1, int max = 1)
{
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        res[i] = new Random().Next(min, max);
    }
    return res;
}

void PrintArray(int[] someArray)
{
    Console.Write("[");
    for (int i = 0; i <= someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}");
}
int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine()!);
    return res;
}