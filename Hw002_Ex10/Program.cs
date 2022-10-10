/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */


int n = 0;
Console.WriteLine("Enter your any number from 100 to 999: ");
n = Convert.ToInt32(Console.ReadLine());


if (n < 100 | n > 999)
{
    Console.WriteLine("Error!You didn't enter number from 100 to 999, try again: ");
}
else
{
    Console.WriteLine();
}



/*if (n > 100 && n < 999)
{
    Console.WriteLine(+""+ second +""+);
*/