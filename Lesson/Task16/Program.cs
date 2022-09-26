// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];
PrintArr(arr);
PrintConsole(arr);

void PrintArr(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
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
