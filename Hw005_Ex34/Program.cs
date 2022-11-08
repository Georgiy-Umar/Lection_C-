using System;

namespace Hw005_Ex34{

internal class Program {

public static void Main(string[] args) {

// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


int from = 100;
int to = 1000;
int[] array = new Int32[4]; 
FillArray(array, from, to);
PrintArray(array);

CheckArr(array);

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
// Console.WriteLine("Enter new array from n numbers: ");
}
void CheckArr(int[] array){

   int check = 0;
    for(int i = 0; i < array.Length; i++ ){
      
       if(array[i] % 2 == 0){
        check++;
       
       
       }
       
       
    } 
     Console.WriteLine("Количество четных чисел равна: " + check);  
}

}
}
}
