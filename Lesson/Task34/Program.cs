// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент
// входных данных.
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
int[] MatrixToOneRowArray(int[,] matrix)
{
    int counter = 0;
    int[] oneRowArray = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            oneRowArray[counter] = matrix[i, j];
            counter++;
        }
    }
    return oneRowArray;
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
void HowManyNumbersInArray(int[] array)
{
    int count = 1;
    int numForCount = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(numForCount == array[i]) count++;
        else 
        {
            Console.WriteLine($"{numForCount} -> {count}");
            numForCount = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{numForCount} -> {count}");
}
int[,] array2D = CreateMatrix(m, n, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] oneRowArray2D = MatrixToOneRowArray(array2D);
PrintArray(oneRowArray2D);
Array.Sort(oneRowArray2D);
PrintArray(oneRowArray2D);
HowManyNumbersInArray(oneRowArray2D);