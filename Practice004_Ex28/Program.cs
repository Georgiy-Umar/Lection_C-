// Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
Console.WriteLine("Enter any number: ");
int num = int.Parse(Console.ReadLine()); //ТАКЖЕ МОЖНО TAK -> int A = int.Parse(Console.ReadLine())

int result = multiply(num);
Console.WriteLine (result);

int multiply    (int number)
{
    int count = 1;
    for (int i =1; i <= number; i++)
    {
        count *= i; // count = count * i;
    }

    return count;
}
