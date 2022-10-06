// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            else Console.Write($"{array[i,j], 4} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageElementsOfColumns(int[,] array)
{
    double[] newArray = new Double[array.GetLength(1)];
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        average = sum / array.GetLength(0);
        newArray[i] = average;
    }
    return newArray;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1)}, ");
        else Console.Write($"{Math.Round(array[i], 1)}, ");
    }
    Console.WriteLine("]");
}

int[,] array = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array);
double[] newArray = AverageElementsOfColumns(array);
Console.WriteLine("----------------------");
PrintArray(newArray);