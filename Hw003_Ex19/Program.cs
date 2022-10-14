// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int number = 0;
Console.WriteLine("Enter 5th digit number: ");
int num = Convert.ToInt32(Console.ReadLine());;
if (num < 10000 | num > 99999)
{
    Console.WriteLine("Error!You didn't enter invalid number, try again: ");
    num = Convert.ToInt32(Console.ReadLine());
}
    
int oldValue = number;
int newValue = 0;
    while (number > 0);
    {
        int digit = number % 10;
        newValue = newValue * 10 + digit;
        number = number / 10;

        if (oldValue == newValue)
        {
        Console.WriteLine("Your number is palendrom!");
        }

else
{
Console.Write("Your number isn't palendrom!");
}}