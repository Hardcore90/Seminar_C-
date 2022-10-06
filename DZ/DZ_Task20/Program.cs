// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите позиции элемента в двумерном массиве: ");
Console.Write("i - ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("j - ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array);
IsThereElementOrNot(array, n1, n2);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i < array.GetLength(1) - 1) Console.Write($"{array[i,j], 4} ");
            else Console.Write($"{array[i,j], 4}");
        }
        Console.WriteLine("|");
    }
}

void IsThereElementOrNot(int[,] array, int n1, int n2)
{
    if(n1 > array.GetLength(0) || n2 > array.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет!");
    else Console.WriteLine($"{array[n1, n2]}!");
}