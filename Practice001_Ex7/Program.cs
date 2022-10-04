Console.Write("Enter any three-digit numer N: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 100 | n > 999)
{
Console.Write("Check your input, you did enter incorrect number and repeat your enter: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("The last digit of the number: " + Convert.ToString(n % 10));