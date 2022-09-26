// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumN(int num)
{
    int sum = default;
    int i = 1;
    while(i <= num)
    {  
        sum = sum + i;
        i++;
    }
    return sum;
}
int SumN2(int number)
{
int sum = default;
for(int i = 1;i <= number; i++)
    {
    sum = sum + i;
    }
    return sum;
}
int result = SumN2(n);
Console.WriteLine($"Сумма чисел от 1 до {n}: {result}");