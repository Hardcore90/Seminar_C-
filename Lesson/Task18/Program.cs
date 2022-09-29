﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size,int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}

void InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = - arr[i];
    }
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
InversArray(arr);
PrintArray(arr);