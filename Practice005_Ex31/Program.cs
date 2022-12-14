/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20. */

int[] arr = new Int32[12];

int positiveNumbersSum = 0;
int negativeNumbersSum = 0;

randomFilling(arr, min:-9, max:10); 
// arrayOutput(arr);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        negativeNumbersSum += arr[i];   
    }
    else
    {
        positiveNumbersSum += arr[i];
    }
}

Console.WriteLine();
Console.WriteLine($"The Sum of positive numbers {positiveNumbersSum}, " +
                  $"The Summ of negative numbers {negativeNumbersSum}");

int[] randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }


return arr;
}







/*void FillArray(int[] array, int from, int to)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(from, to+1); 
}
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
System.Console.Write($"{array[i]}, "); 
}
System.Console.Write($"{array[array.Length - 1]}"); 
}*/