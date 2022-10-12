// Напишите программу, которая принимает на входе
// число N и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1,4,9,16,25
// 2 -> 1,2
Console.Write("Enter any numbers: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N;i++)
{
    Console.Write($"{i * i} ");
}





