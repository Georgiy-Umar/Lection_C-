using System;

namespace Hw005_Ex38{

class Program {

static void Main() {

// Задайте массив вещественных чисел. 
// Nайдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int from = 0;
int to = 10;
int[] array = new Int32[5]; 
FillArray(array, from, to);
PrintArray(array);
int MaxMinArr = MaxArr(array) - MinArr(array);
 Console.WriteLine("Разница чисел равна: " + MaxMinArr); 

int FillArray(int[] array, int from, int to){

    for(int i = 0; i < array.Length; i++){
            array[i] = new Random().Next(from, to);
    }
      return new Int32();
    }

void PrintArray(int[] array){

    for(int i = 0; i <array.Length; i++){
        Console.Write($"{array[i]},");
    }    
    Console.WriteLine(" ");
    }
int MaxArr(int[] array){

   int maxarr = array[0];
 
    for(int i = 0; i < array.Length; i++)
    {
       if(maxarr < array[i])
       {
       maxarr = array[i];
       }  
     }
    return maxarr;
    }
int MinArr(int[] array){

         int minarr = array[0];

        for(int i = 0; i < array.Length; i++)
        {
            if(minarr > array[i])
            {
             minarr = array[i];
            }
        }
       return minarr;
    }

} 
 
}

}

