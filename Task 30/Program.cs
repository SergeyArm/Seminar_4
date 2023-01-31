// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int i = 30;
// int count = 0;
// while (count<i)
// {
// int A = new Random().Next(0, 2);
// Console.Write(A);
// count++;
// }

int[] array = new int[30];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    // Console.Write(array[i] + " "); // Вывод массива
}

// Можно вывести массив следующим образом:
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// Красивый вывод массива:
Console.Write('['+string.Join(", ", array)+ ']');