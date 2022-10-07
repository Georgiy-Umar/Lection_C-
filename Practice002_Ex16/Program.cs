 /*Необходимо написать программу, которая принимает на вход два числа
 и проверяет, является ли одно число квадратом другого */

 Console.Write("Enter any number a: ");
 int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter any number b: ");
 int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || a / b == b)
{
    Console.WriteLine("The number a is square of number b");
}
else
{
Console.WriteLine("The number is't square");
}