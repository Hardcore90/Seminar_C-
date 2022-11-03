// Задача 69. Напишите программу, которая на вход принимает два числа
// A и B, и возводит число A в целую степень B с помощью рекурсии.

Console.WriteLine("Введите А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B: ");
int b = Convert.ToInt32(Console.ReadLine());
int NumberAToPowOfB(int num1, int num2)
{
    int multiply = 1;
    if(num2 == 0) return 1;
    {
        multiply = num1;
        multiply *= NumberAToPowOfB(num1, num2-1);
    }
    return multiply;
}
int res = NumberAToPowOfB(a, b);
Console.WriteLine($"A = {a}, B = {b} -> {res}");