﻿//f(n) = f(n-1) + f(n-2)

int fibonacci(int n)
{
    if( n == 1 || n ==2 ) return 1;
    else return fibonacci(n-1) + fibonacci(n-2);
}

for (int i =1; i < 50; i++)
{
    Console.WriteLine($"f({i}) =  {fibonacci(i)}");
}

