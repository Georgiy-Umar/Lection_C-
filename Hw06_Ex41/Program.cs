// Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int number = 0;
while (true)
{
    Console.WriteLine("Enter your numbers: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number > 0 && number <= 5)
    {
        Console.WriteLine("Enter your numbers: ");
        int sum = appSum(number);
        Console.Write($"вы ввели {sum} чисел больше нуля.");
        break;
    }
    else
    {
        Console.WriteLine(number);
    }
}

int appSum(int number)
{
    int i = 0;
    int count = 0;
    while ( i < number)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            count++;
        }
        i++;
    }
    return count;
}