// F(1) = 1
// f(2) = 1
// f(3) = f(3 - 1) + f(3 - 2) = 3
// f(n) = f(n - 1) + f(n - 2)
// Fibonacci это когда каждая следующаяя цифра равна сумме двух предидущих цифр

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
    for(int i = 1; i < 60; i++)
    {
        Console.WriteLine($"f({i!}) = {Fibonacci(i)}");
    }