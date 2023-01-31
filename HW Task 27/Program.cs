// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int B = 0;
int C = A;
while (C%10>0)
{
B = B+C%10;
C =C/10;
}
Console.WriteLine("Сумма цифр числа "+A + " равна "+B);