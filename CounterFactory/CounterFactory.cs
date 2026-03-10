using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

class CounterFactory
{
    public static Func<int> CreateSimpleCounter()
    {
        int count = 0;
        return () =>
        {
            count++;
            return count;
        };
    }

    public static Func<int> CreateStepCounter(int step)
    {
        int count = 0;
        return () =>
        {
            for (int i = 0; i < step; i++) { count++; }
            return count;
        };
    }

    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int count = min;
        return () =>
        {
            if (count > max)
            {
                count = min;
            }
            return count++;
        };
    }
    public static void CreateResettableCounter(out Action action, out Func<int> func)
    {
        int count = 0;
        action = () =>
        {
            count++;
            Console.Write($"{count} ");
        };
        func = () => count = 0;
    }

}