// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Factorial(int num)
{
    int f = 1;
    int i = 1;
    while(i <= num)
    {  
        f = F * i;
        i++;
    }
    return f;
}
int SumN2(int number)
{
int f1 = 1;
for(int i = 1;i <= number; i++)
    {
    f1 = f1 * i;
    }
    return F1;
}
int result = Factorial(n);
Console.WriteLine($"Произведение чисел от 1 до {n}: {result}");
