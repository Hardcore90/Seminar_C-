// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubeTable(int num)
{
    int counter = 1;
    while(counter <= num)
    {
        Console.WriteLine($"| {counter,3} | {counter*counter*counter,5} |");
        counter++;
    }
}

if (number > 0) CubeTable(number);
else Console.WriteLine("Введено некорректное значение!");