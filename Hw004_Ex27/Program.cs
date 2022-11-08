// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Enter any number: ");

string number = Console.ReadLine();

int Length = number.Length;

int result = 0;

for (int i = 0; i < Length; i++)
{
    result = result + Convert.ToInt32(Convert.ToString(number[i]));
}
Console.WriteLine(result);