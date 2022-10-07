/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Enter any number a: ");
 int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter any number b: ");
 int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("The number a > b"); //WriteLine команда вывода того что в скобках//
}                                          /*при выводе двух чисел склеить их a+""+b 
                                           например а =4 в =6 то при выводе будет 46 а не сумма 10. */
else if (a == b) Console.WriteLine("The numbers a == b");
else
{
Console.WriteLine("The number b > a");
}