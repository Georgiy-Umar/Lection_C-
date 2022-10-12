// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
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
    int DecreaseByten = n / 10; 
    int third = n%10;;
    Console.WriteLine("Third digit from n is =" + third);
}



















/*int N = 0;
Console.WriteLine("Enter your any number from 100 to 999: ");
string N = Console.ReadLine();
string Check (string N) //процесс проверки значений введенной строки
{
    m1:
    while (N == "")
    {
        Console.ReadLine("Your String is empty, try again: ");
        N = Console.ReadLine();
    
    }
    try 
    {
        Convert.ToInt32(N);
    }
    catch (FormatException)
    {
        Console.Write("Your string is not a number, please try again: ");
        N = Console.ReadLine();
        goto m1;
    }
    catch (OverflowException)
    {
        Console.Write( )
    }








// if (n < 100 | n > 999)
}*/