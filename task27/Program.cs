//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int summery(int num)
{
while (a > 0)
    {
    sum = sum + a%10;
    a = a/10;
    }
    {
    return sum;
    }
}

Console.WriteLine("Сумма цифр в введёном числе равняется: " + summery(a));