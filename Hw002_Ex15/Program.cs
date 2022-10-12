// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Enter a number of the weeks day (from 1 to 7): ");
int weekDay = Convert.ToInt32(Console.ReadLine());
if (weekDay < 1| weekDay > 7) 
{
    Console.WriteLine("You did Enter the incorrect number, repeat your enter again!: ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay == 1)
{
    Console.WriteLine("The Monday is workday in Russia! Enter next number of another day: ");
    weekDay = Convert.ToInt32(Console.ReadLine()); 
}    
if (weekDay == 2)
{
    Console.WriteLine("The Tuesday is workday in Russia! Enter next number of a day: ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay == 3) 
{
    Console.WriteLine("The Thirsday is workday in Russia! Enter next number of another day: ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay == 4)
{
    Console.WriteLine("The Wednesday is workday in Russia! Enter next number of another day: ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay == 5) 
{   
    Console.WriteLine("The Friday is holyday in muslims contury! Enter next number of another day: ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay == 6) 
{
    Console.WriteLine("The Saturday is holyday in Russia! Enter next number of another day: ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if (weekDay == 7) 
{
    Console.WriteLine("The Sunday is BEST holyday in Russia!");
    weekDay = Convert.ToInt32(Console.ReadLine());
}

