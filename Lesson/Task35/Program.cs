// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
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
int[] MinIndex(int[,] matrix)
{
    int[] indexMin = new int[1];
    int minInMatrix = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < minInMatrix)
            {
                minInMatrix = matrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
   return indexMin;
}
int[,] DeleteRowColumnMin(int[,] matrix, int[] arr)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if(i != arr[0])
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if(j != arr[1]) newMatrix[i,j] = matrix[i,j];
        }
    }
    return newMatrix;
}
int[,] matrix = CreateMatrix(m, n, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[] minIndexOfMatrix = MinIndex(matrix);
int[,] newMatrix = DeleteRowColumnMin(matrix, minIndexOfMatrix);
PrintMatrix(newMatrix);