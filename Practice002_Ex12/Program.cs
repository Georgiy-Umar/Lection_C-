/* Напишите программу, которая будет принимать
на вход два числа и выводить, является ли первое
число кратным второму. Если число 1 не кратно числу 2,
то программа выводит остаткy.
34, 5 -> не кратно, остаток 4
16, 4 ->  кратно
*/
int a = 0;
int b = 0;
Console.WriteLine("Enter any divident numbers: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter any divider number; ");
b = Convert.ToInt32(Console.ReadLine());

int r = a % b;
if (r == 0)
{
    Console.WriteLine("IT IS DIVISIBLE");
}
else 
{
    Console.WriteLine("IT's NOT DIVISIBLE AND REMINDER IS =" + r);
}
