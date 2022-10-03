// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool CheckTriangle(int n1, int n2, int n3)
{
    return (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2);
}

if (CheckTriangle(num1, num2, num3)) Console.WriteLine("Треугольник со сторонами такой длины может сущевстсвовать!");
else Console.WriteLine("Треугольник со сторонами такой длины НЕ может сущевстсвовать!");