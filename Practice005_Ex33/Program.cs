// адайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
 
 int[] arr = new int[12];

 void newArray(int[]array)
 {
    for (int i = 0; i < array.Length; i++);
    {
        array[i] = new Random().Next(-9, 10);
    }
 }

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    {
    Console.Write($"{array[i]}");
    if (i < (array.Length-1)) Console.Write($", ");
    }
    Console.WriteLine(); 
}

newArray(arr);
PrintArray(arr);

Console.WriteLine("Enter any number: ");

int number = Convert.ToInt32(Console.ReadLine());

string result = Poisk (arr, number)? $"The number{number} is at the array" : $"The number{number} isn't at the array";
Console.WriteLine(result);

bool Poisk(int[]array, int n)
{
    bool h =false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == n) 
        {
            h = true;
            break;
        }
    }
    return h;
}
