// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int i = 0;

// Способ 1
// for (int n = 0; A != 0; n++) // A != 0 - A не равно нулю
// {
//     A /= 10;
//     i++;
// }

// Способ 2
// int i = 0;
// while (A > 0)
// {
//     A = A / 10; // A /=10
//     i++;
// }

// Console.WriteLine(i);

Способ 3
string A = "" + Console.ReadLine();
if (int.TryParse(A, out int B)) // int.TryParse(A, out int B) - оперирует переменной bool (True или False)
                                // и проверяет является ли введенные знаки числом. out int B - выходная
                                // переменная. В данной задаче не используется
{
    Console.WriteLine(A.Length);
}
else
{
    Console.WriteLine("Ошибка");
}