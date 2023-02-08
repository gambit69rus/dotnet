// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array1 = new int[8];
int[] array2 = new int[8];
int[] array3 = new int[8];

RandomArray(array1);
PrintArray(array1);
Console.WriteLine(" ");

RandomArray(array2);
PrintArray(array2);
Console.WriteLine(" ");

SumArray(array1, array2, array3);
PrintArray(array3);

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + ",");
    }
}
void RandomArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void SumArray(int[] array1, int[] array2, int[] array3)
{
    for (int i = 0; i < 8; i++)
    {
        array3[i] = array1[i] + array2[i];
    }
}
