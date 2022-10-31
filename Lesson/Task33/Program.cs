// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] CreateMatrix(int rows, int collumns, int min, int max)
{
    int[,] matrix = new int[rows, collumns];
    var rnd = new Random();
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
int[,] SwapRowsAndCollumns(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}
int[,] res = CreateMatrix(m, n, 1, 10);
PrintMatrix(res);
if (res.GetLength(0) == res.GetLength(1))
{
    Console.WriteLine();
    int[,] newMatrix = SwapRowsAndCollumns(res);
    PrintMatrix(newMatrix);
}
else Console.WriteLine("Невозможно заменить строки на столбцы!");
