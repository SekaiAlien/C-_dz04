// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = GetArray(8);
Console.WriteLine(String.Join(", ", array)); 

int[] GetArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}