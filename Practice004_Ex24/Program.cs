// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Enter any number: ");
int A = Convert.ToInt32(Console.ReadLine()); //ТАКЖЕ МОЖНО TAK -> int A = int.Parse(Console.ReadLine())
int sum = 0;
for (int i = 1; i <= A; i++)
{
sum += i;//переменная сум (sum = sum - i)  
}
Console.WriteLine(sum);


