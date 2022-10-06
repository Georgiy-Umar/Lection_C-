/*Напишите программу, которую выводит случайное число из отрезка [10,99]
 и показывает наибольшую цифру числа.*/

 int n = new Random().Next(10, 99);
// команда new добавляет новый объект рандома//
 Console.WriteLine(n);
//Данной конструкцией мы определили рандомно переменную N//
int first = n/10;
int second = n%10;

Console.WriteLine(first);
Console.WriteLine(second);

if(first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}    