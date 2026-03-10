using System;

// 1
Calculator calc = delegate(int x) { return x * x; };
Console.WriteLine(calc(5));
Console.WriteLine();

// 2
int factor = 3;
Func<int, int> multiplier = delegate (int n) { return n * factor; };
Console.WriteLine(multiplier(10));
Console.WriteLine();

// 3
factor = 2;
Console.WriteLine($"factor = {factor}일 때: {multiplier(5)}");
factor = 10;
Console.WriteLine($"factor = {factor}일 때: {multiplier(5)}");
Console.WriteLine();

// 4
int counter = 0;
Action increment = delegate
{
    counter++;
    Console.WriteLine($"현재 카운터: {counter}");
};

increment();
increment();
increment();
Console.WriteLine();
Console.WriteLine($"최종 카운터: {counter}");
Console.WriteLine();

// 5
static Func<int> CreateCounter()
{
    int count = 0;
    return () =>
    {
        count++;
        return count;
    };
}

Func<int> counter1 = CreateCounter();
Func<int> counter2 = CreateCounter();
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter2: {counter2()}");
Console.WriteLine($"counter2: {counter2()}");


// 1
delegate int Calculator(int x);