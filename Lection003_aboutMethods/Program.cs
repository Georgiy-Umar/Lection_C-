/*/ Вид методов №1
void Method1()
{
    Console.WriteLine("Автор Аб"); //что-то вывести через команду,где в конце программы хочу указать свое авторство
}
/* Вариант как вызываются функции:
1 необходимо указать идентификатор этого метода как в примере выше: "Method1();"
Method1(); */

/* Метод№2:
Ничего не возвращают, но могут принимать какие-то аргументы:

void Method2(string msg)
{
Console.WriteLine(msg);
}
Method2("Text message"); /*также бывают именованные аргументы, 
где хотим указать к какому аргументу какое значение хотим указать 
Например: Method2(msg: text of massege); - это нужно когда методы 
принимают какое-то несколько аргументов. */

/*void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;  
        ИНКРИМЕНТ - увеличение счетчика на 1 ед.
        ДЕКРИМЕНТ - уменьшение счетчика на 1 ед.
    }
}
Method21(count: 4, msg: "New Text 4 raza" );
** также можно не попорядку: Method21(count: 4, msg: "Text 4 raza"); */

/* Метод№3
Должны в обязательном порядке указать тип данных, которые мы ожидаем. 
int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year); */

/* Метод№4

string Method4(int count, string document)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + document;
        i++;
    }
    return result;
}
string res = Method4(10, "text budem skleivat 10 raz");
Console.WriteLine(res); */
/*Также кроме цикла while есть for//
string Method4(int count, string document)
{
    
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + document;
    }
    return result;
}
string res = Method4(10, "text budem skleivat 10 raz");
Console.WriteLine(res);
*/

/*также существуют цикл в цикле
for(int i = 2; i <= 10; i++)
{
    for(int j =2; j <= 10; j++)
    {
    Console.WriteLine($"{i} * {j} = {i * j}"); //метод интерполяция строк
    }
    Console.WriteLine();
}
*/

/*
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками, 
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
Ясна ли задача?*/

/* string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = qwerty
//            012
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";

    } 
    return result; 
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);*/

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; 

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }//чтобы сортировать от малого к большому = > (array[j] > array[maxPosition]) maxPosition = j≥
        // также необходимо изменить с maxPosition => minPosition
        int temporary = array [i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);