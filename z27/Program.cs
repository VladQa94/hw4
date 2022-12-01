/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int sumNumber(int numberA)
{
    int sum = 0;
    while (numberA > 0)
    {
       int mod = numberA % 10;
       sum = sum + mod;
       int div = numberA / 10;
       numberA = div;
    }
    return sum;
}

int summa = sumNumber(numberA);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Сумма цифр в числе {numberA} = {summa}");
Console.ResetColor();
