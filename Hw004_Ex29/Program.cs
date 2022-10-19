// Напишите программу, которая задаёт массив произвольной длины, 
// заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Enter any array from 0 to 8 numbers: ");

int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
void newArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,8);
    }
}
void PrintArray(int[]array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i <(array.Length-1)) Console.Write($", ");//а тут запятая будет до последней цифры

        //Console.Write($"{array[i]},"); //в данном случае "," после } при выводе будет стоть после цифры
    }
    Console.WriteLine();
}    
newArray(arr);
PrintArray(arr);