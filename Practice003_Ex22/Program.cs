// Напишите программу, которая принимает на входе
// число N и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1,4,9,16,25
// 2 -> 1,2
/*bool one = true;  //этот тоже отличный вариант кода!!!
while (one)
{
    try 
    {
        Console.WriteLine("Enter any number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int index = 0;
        for (int i = 1; i <= num; i++)
        {
            index = (int)Math.Pow(i,2); // возведение в степень числа и в 2ю степень
            if (i == num) Console.Write(index + ".");
            else
            Console.Write(index + ",");
        } 
        one = false;
    }
    catch
    {
        Console.WriteLine("Error! Try again: ");
    }

}
*/

Console.Write("Enter any numbers: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N;i++)
{
    Console.Write($"{i * i} ");
}





