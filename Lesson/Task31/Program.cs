// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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
            if(i < array.GetLength(1) - 1) Console.Write($"{array[i,j]} ");
            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("|");
    }
}

int SumDiagonalElement(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j) sum = sum + array[i, j];
        }
    }
    return sum;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
int res = SumDiagonalElement(array2D);
Console.WriteLine($"Сумма равна = {res}");


// int[,] myArray = CreateMatrix(4, 3, 1, 9);  //Одним циклом!
// PrintMatrix(myArray);
// Console.WriteLine();
// Console.WriteLine($"{SummOfEqualIndex(myArray)}");


// int SummOfEqualIndex(int[,] matrix)
// {
//     int sum = default;
//     int targetSize = 0;
//     if ( matrix.GetLength(0) > matrix.GetLength(1)) targetSize = 1;
//     for (int i = 0; i < matrix.GetLength(targetSize); i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }
