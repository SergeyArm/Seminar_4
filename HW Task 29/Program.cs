// Напишите программу, которая создает массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите число элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Выберите способ решения 1 или 2: ");
int method = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Способ " + method+":");

switch (method)
{
    case 1:
        int count = 0;
        while (count < q)
        {
            int B = new Random().Next(0, max + 1);
            Console.Write(" " + B);
            count++;
        }
        break;
    case 2:

        int[] array = new int[q];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, max + 1);
        }

        Console.Write('[' + string.Join(", ", array) + ']');
        break;
}