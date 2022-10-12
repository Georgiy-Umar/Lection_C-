// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние
// между ними в 2Д пространствe
// А(3,6) В(2,1)->5,09
// A(7,5) B(1,-1) ->7,21
Console.WriteLine("input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A1A2 Length is: "+ Math.Sqrt((x1 - x2)*(x2 - x2)+(y1 -y2)*(y1 - y2)));