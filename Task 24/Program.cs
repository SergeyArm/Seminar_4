// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.

// Начало метода
int Sum(int x)
{
    int sum = 0;
    for(int i = 1; i <= x; i++)
    {
        sum += i; // sum=sum+i
    }
    return sum;
}
// Конец метода

// Начало запроса на вызов метода
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int sum = Sum(A); // Вызов метода

Console.WriteLine(sum); // Вывод результата