/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int Exponentiation(int numberA1, int numberB1)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int exponentiation = Exponentiation(numberA, numberB);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{numberA} в {numberB} степени  = {exponentiation}");
Console.ResetColor();