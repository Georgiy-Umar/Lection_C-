/*Написать программу которая принимает
 на вход число и проверяет кратно ли оно одновременное 7 и 23. */

Console.WriteLine("Enter any number a: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
Console.WriteLine("Excelent! Your number is a multiple 7 and 23");
}
else
{
Console.WriteLine("Excelent! Your number is not a multiple 7 and 23");  
}
