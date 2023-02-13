// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int size = 123;
int min = -200;
int max = 200;
int[] arr = GetArray(size, min, max);

PrintArray(arr);
Console.Write($"колличество элементов массива в диапазоне [10,99] составляет: ");
Console.WriteLine($"{CountArrayInterval(arr, 10, 99)}.");

int CountArrayInterval(int[] someArray, int minInterval, int maxInterval)
{
    int counter = 0;
    for (int i = 0; i <= someArray.Length - 1; i++)
    {
        if ((someArray[i] >= minInterval) && (someArray[i] <= maxInterval)) counter++;
    }
    return counter;
}

int[] GetArray(int length, int min = -1, int max = 1)
{
    int[] res = new int[length];
    for (int i = 0; i < length; i++) res[i] = new Random().Next(min, max);
    return res;
}
void PrintArray(int[] someArray)
{
    Console.Write("[");
    for (int i = 0; i <= someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}