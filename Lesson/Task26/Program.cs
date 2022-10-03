// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] CreateArrayRndInt(int size,int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max+1);
    }
    return array;
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

int[] CopyArray(int[] arr1)
{
    int[] newArr = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        newArr[i] = arr1[i];
    }
    return newArr;
}

int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
int[] arr2 = CopyArray(arr);
PrintArray(arr2);