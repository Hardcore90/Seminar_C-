// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size,int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (min + max) - min), 1);
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}   ");
        else Console.Write($"{array[i]}   ");
    }
    Console.Write("]");
}

double DiffMinMaxElem(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    return max - min;
}

double[] arr = CreateArrayRndInt(5, 0, 100);
PrintArray(arr);
double res = Math.Round(DiffMinMaxElem(arr), 1);
Console.Write($"-> {res}");