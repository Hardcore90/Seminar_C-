// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Fibonacci(n);


void Fibonacci(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    Console.Write($"{firstNum} {secondNum} ");
    for (int i = 2; i < num; i++)
    {
        int nextNum = firstNum + secondNum;
        Console.Write($"{nextNum} ");
        firstNum = secondNum;
        secondNum = nextNum;
    }
}

// int[] array = new int[5];           // с помощью массива!
// CreateFibonacciRow(array);
// PrintArray(array);

// void CreateFibonacciRow (int[] arr)
// {
//     arr[0] = 0;
//     arr[1] = 1;
//     for (int i = 2; i < arr.Length; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
// }
