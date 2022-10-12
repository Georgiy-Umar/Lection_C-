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
Console.WriteLine("Enter your any number from 100 to 999: ");
n = Convert.ToInt32(Console.ReadLine());
}
if(n >= 100 | n <= 999)
{
    int DecreaseByten = n / 10; //этот блок не понял откуда взялся ??? ((
    int LastDigit = DecreaseByten % 10;
    Console.WriteLine("Second digit from n is =" + LastDigit); // тут думал подойдет вот эта команда Console.WriteLine(+""+ second +""+);
}
