// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());

int AToTheDegreeOfB(int n1, int n2)
{
    int res = n1;
    for (int i = 1; i < n2; i++)
    {
        res = res * n1;
    }
    return res;
}

if(b < 1) Console.WriteLine("Некорректные данные!");
else
{
int result = AToTheDegreeOfB(a, b);
Console.WriteLine($"Число {a} в степени числа {b} -> {result}!");
}