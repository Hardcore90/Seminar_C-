// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
int[,] CreateMatrix(int size, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}
int MinSumElementsOfRowsMatrix(int[,] matrix)
{
    int[] arrayOfSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        arrayOfSum[i] = sum;
    }
    int minIndexOfMinSum = 0;
    int min = arrayOfSum[0];
    for (int i = 1; i < arrayOfSum.Length; i++)
    {
        if (arrayOfSum[i] < min)
        {
            min = arrayOfSum[i];
            minIndexOfMinSum = i;
        }
    }
    return minIndexOfMinSum + 1;
}
int[,] matrix = CreateMatrix(5, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int res = MinSumElementsOfRowsMatrix(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {res} строка!");