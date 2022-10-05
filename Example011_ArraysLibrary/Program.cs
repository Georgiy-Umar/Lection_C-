/* ДАННЫЙ МЕТОД - "МЕТОД ЗАПОЛНЕНИЯ МАССИВА"
void FillArray(int[] collection) 
/*void оператор для невозврата позиций,
и в этом случае не прийдется использовать 
оператор return
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}


void PrintArray(int[] collect)
{
    int count = collect.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collect[position]);
        position++;
    }
}

int [] array = new int [10]; //конструкция "new int"-Создай новый массив в котором будет 10 элементов.

FillArray(array);
PrintArray(array); */

// Задача на поиск нужного элемента с использовнием "Метода":

void FillArray(int[] collection) 
/* void оператор для невозврата позиций,
и в этом случае не прийдется использовать 
оператор return */
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[]collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
        while (index < count)
        {
            if(collection[index] == find)
                {
                position = index;
                }
                index++;
        }
        return position;
        
}

int[] array = new int [10]; //конструкция "new int"-Создай новый массив в котором будет 10 элементов.

FillArray(array);
PrintArray(array); 
Console.WriteLine();

int pos = Indexof (array, 444);
Console.WriteLine(pos);
