using System;

namespace Hw005_Ex34{

internal class Program {

public static void Main(string[] args) {

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// 2


int from = 10;
int to = 100;
int[] array = new Int32[4]; 
FillArray(array, from, to);
PrintArray(array);
SumCheckArr(array);

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


}
static void SumCheckArr(int[] array){

   int result = 0;
    for(int i = 0; i < array.Length; i++ ){
      
       if(array[i] % 2 != 0){
        result =result + array[i]; // 
        result += array[i];
       
       
       }
       
       
    } 
     Console.WriteLine("Сумма нечетных чисел равна: " + result);  
}

}
}
}
