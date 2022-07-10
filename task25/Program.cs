// Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

double Step (int x, int y)
{
    double Step = Math.Pow(x, y);
    return Step;
}


Console.WriteLine("Число A возведённое в степень B равняется: " + Step(a, b));