using System;

Func<int> counter = CounterFactory.CreateSimpleCounter();

Console.WriteLine("=== 단순 카운터 ===");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.WriteLine("\n");
Console.WriteLine("=== 스텝 카운터 (step = 3) ===");
counter = CounterFactory.CreateStepCounter(3);
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.WriteLine("\n");
Console.WriteLine("=== 범위 카운터 (1~3) ===");
counter = CounterFactory.CreateBoundedCounter(1, 3);
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.Write($"{counter()} ");
Console.WriteLine("\n");
Console.WriteLine("=== 리셋 가능 카운터 ===");
Console.Write("호출: ");
CounterFactory.CreateResettableCounter(out Action action, out Func<int> func);
action();
action();
action();
func();
Console.WriteLine();
Console.Write("리셋 후: ");
action();
action();





