// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];
PrintArr(arr);
PrintConsole(arr);

void PrintArr(int[] array)
{
    Random rd = new Random();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rd.Next(0,100);
    }
}

void PrintConsole(int[] arr1)
{
    int count = arr1.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr1[i]} ");
    }
}
