// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В. (Без использования Math.Pow)

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = 1;
for(int i = 0; i<B; i++)
{
   C = C*A;
}
 Console.WriteLine("А в степени B равно "+ C);
