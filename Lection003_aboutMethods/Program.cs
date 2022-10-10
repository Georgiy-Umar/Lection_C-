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
*/
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
Console.WriteLine(res);