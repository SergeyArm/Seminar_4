// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int Mult(int x)
{
    int mult = 1;
    for(int i = 1; i <= x; i++)
    {
        mult *= i;
    }
    return mult;
}
// Конец метода

// Начало запроса на вызов метода
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int mult = Mult(A); // Вызов метода

Console.WriteLine(mult); // Вывод результата