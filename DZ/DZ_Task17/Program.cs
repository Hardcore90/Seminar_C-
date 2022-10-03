// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько цифр вы хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
PrintArray(array);
int res = CountPositiv(array);
Console.Write($"-> Количество чисел больше 0: |{res}|");

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

int CountPositiv(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}