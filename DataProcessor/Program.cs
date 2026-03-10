using System;
using System.Collections.Generic;

DataProcessor arr = new DataProcessor { nums = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } };

Console.WriteLine("=== 원본 배열 출력 ===");
Console.WriteLine(string.Join(" ", arr.nums));
Console.WriteLine();
Console.WriteLine("=== 2배로 변환 ===");
Action<int> doubleNum = x => Console.Write($"{x*2} ");
arr.Foreach(doubleNum);
Console.WriteLine("\n");
Console.WriteLine("=== 짝수만 필터링 ===");
Func<int, bool> EvenNums = x => x % 2 == 0;
Console.WriteLine(string.Join(" ", arr.Filter(EvenNums)));
Console.WriteLine();
Console.WriteLine("=== 합계 계산 ===");
Func<int, int, int> Reducer = (x, y) => x + y;
Console.WriteLine($"합계: {arr.Reduce(Reducer, 0)}");