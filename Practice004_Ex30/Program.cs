// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// 1,0,1,1,0,1,0,0

int[] arr = new int[8];
void newArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
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