//Напишите программу, которая принимает на вход координаты точки (Х и У), 
// причем Х ≠ 0 и У ≠ 0 и выдает номер четверти плоскости, 
// в которой находится эта точка.
Console.WriteLine("Enter cordinats of X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter cordinats of Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("First quater!");
}
if (x < 0 && y > 0)
{
    Console.Write("Second quater!");
}
if (x > 0 && y < 0)
{
    Console.Write("Thirth quater!");
}
if (x < 0 && y < 0)
{
    Console.Write("Forth quater!");
}