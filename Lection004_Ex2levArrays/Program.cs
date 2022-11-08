// string[,] table = new string[2, 5];//2 string 5 column
// для строк инциализация происходит Strint.Empty
 //table [0, 0] table [0,1] table [0, 2] ... and last table [0, 4]
// table[1, 0] table [1, 1] table [1, 2] ... and last table [1, 4]

// table[1, 2] = "a word"; // 1 индекс строки, 2 индекс столбца

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-"); //воспользуемся интерпаляцией через имя элентов массива "table" имя массива
//         //дальше индекс элемента строки"rows", и индекс столбца "columns"
//     }
// }
/*
void PrintArray(int[,] matr);
{
for (int i = 0; i < matr.GetLength(0); i++) //так же можно сделать 
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} "); //воспользуемся интерпаляцией через имя элентов массива "matrix" 
        //имя массива дальше индекс элемента строки"i", и индекс столбца "j"
    }
Console.WriteLine();
} 
}
int[, ] matrix = new int[3, 4];

PrintArray(matrix);*/

/*void PrintArray(int[,] matr);
{
    for (int i = 0; i < matr.GetLength(0); i++) //так же можно сделать 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} "); //воспользуемся интерпаляцией через имя элентов массива "matrix" 
            //имя массива дальше индекс элемента строки"i", и индекс столбца "j"
        }
    }
}

/*void FillArray(int[,] matr);
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
        for (int j = 0; j < matr.GetLength(1); j++);
        {
            matr[i,j] = new Random().Next(1,10); // [1;10) это полуинтервал
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
// FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
} }
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);//[1; 10)
        }
}
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);