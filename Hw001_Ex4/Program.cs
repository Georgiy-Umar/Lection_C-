/* Nапишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.Write("Enter your any number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your any number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your any number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)
{
    max = b ;
}
if (c > b)
{
    max = c;
}
    Console.WriteLine("Max number:" + max);