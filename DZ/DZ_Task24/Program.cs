// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateMatrix(int m, int n, int min, int max)
{
    Random rnd = new Random();
    int[,] matrix = new int[m, n];
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
int[,] MultiplyTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                newMatrix[i, j] = newMatrix[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return newMatrix;
}
int[,] matrix1 = CreateMatrix(2, 2, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrix(2, 3, 1, 10);
PrintMatrix(matrix2);
if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить!");
else
{
    Console.WriteLine("Произведение двух данных матриц равно: ");
    int[,] newMatrix = MultiplyTwoMatrix(matrix1, matrix2);
    PrintMatrix(newMatrix);
}
