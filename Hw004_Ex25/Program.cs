// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int x = A;
int stepen = B;

Math.Pow(x, stepen);

Console.Write(Math.Pow(x, stepen));
