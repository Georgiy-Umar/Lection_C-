// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = new Int32[4];

randomFilling(array, min:-9, max:10); 
arrayOutput(array);
singChange(array);
arrayOutput(array);

void singChange(int[] arr) // функция заготовка
{
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1; //метода преобразования поменять знак у элемента массива
    }

}


void randomFilling(int[] arr, int min, int max) // функция заготовка
{
for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }

}
void arrayOutput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
       { 
        Console.Write($"{arr[i]}");
        if(i < (arr.Length-1)) Console.Write($", ");
       }
       Console.WriteLine();
}
