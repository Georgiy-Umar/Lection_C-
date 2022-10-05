int [] array = { 1, 3, 6, 9, 5, 3 };

int n = array.Length;
int find = 3;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
        /* а в случае если в массиве будут несколько 
        одиинаковых цифр например: indexes [2,5], и по условиям
        необходимо найти только один индекс, то в этом случае 
        необходимо добавить команду "brake" */

    }
    index ++ ; //или index + 1; // также можно указать index =+ 1
}