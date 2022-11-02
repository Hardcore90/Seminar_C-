// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int count = 0;
    int i = 0;
    int j = 0;
    int[,] matrix = new int[m, n];
    for (j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = count + 1;
    }
    for (i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[i,n - 1] = count + 1;
    }
    for (j = n - 1, j < lengt, j--)
    {
        
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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}
int[,] matrix = CreateMatrix(4,4,1,16);
PrintMatrix(matrix);