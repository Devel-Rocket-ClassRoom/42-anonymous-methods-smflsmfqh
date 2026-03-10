using System;
using System.Collections.Generic;

// 1
Calculator anonymous = delegate (int x)
{
    return x * x;
};
Calculator lambda = x => x * x;

Console.WriteLine($"익명 메서드: {anonymous(4)}");
Console.WriteLine($"람다식: {lambda(4)}");
Console.WriteLine();

// 2
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> evenNums = Filter(nums, delegate (int x)
{
    return (x % 2 == 0);
});
List<int> fiveOverNums = Filter(nums, delegate (int x)
{
    return x > 5;
});
Console.WriteLine($"짝수: {string.Join(", ", evenNums)}");
Console.WriteLine($"5보다 큰 수: {string.Join(", ", fiveOverNums)}");
Console.WriteLine();

// 3
int factor = 10;
Func<int, int> normalMethod = delegate (int n) { return n * factor; };
Func<int, int> staticMethod = static delegate (int n) { return n * 2; };
Console.WriteLine(normalMethod(5));
Console.WriteLine(staticMethod(5));
static List<int> Filter(int[] source, Func<int, bool> predicate)
{
    List<int> results = new List<int>();
    foreach (int x in source)
    {
        if (predicate(x)) { results.Add(x); }
    }
    return results;
}

// 1
delegate int Calculator(int x);
