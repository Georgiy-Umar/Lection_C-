// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Enter any numbers: ");

int a = Convert.ToInt32(Console.ReadLine());     //int.Parse(Console.ReadLine());
int count = 0;

if (a == 0)
{
    count = 1;
}
    else while(a != 0)
    {
    a /= 10;
    count += 1;
    }

Console.WriteLine(count);










