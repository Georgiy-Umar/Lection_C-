// Напишите программу, которая по заданному
// номеру четверти, показывает диапозон 
// возможных координат точек  в этой четверти (х и у).
Console.WriteLine("Enter number of quarter(1,2,3,4): ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter < 1 | quarter > 4)
{
    Console.Write("Error! You did enter incorrect number, enter number from 1 to 4 again!");
}

if (quarter == 1)
{
    Console.Write("x > 0 and y > 0");
}
if (quarter == 2)
{
    Console.Write("x < 0 and y > 0");
}
if (quarter == 3)
{
    Console.Write("x > 0 and y < 0");
}
if (quarter == 4)
{
    Console.Write("x < 0 and y < 0");
}