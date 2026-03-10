using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

class DataProcessor
{
    public int[] nums;
    public void Foreach(Action<int> action)
    {
        foreach (int x in nums) { action(x); }
    }
    public int[] Transform(Func<int, int> transformer)
    {
        int[] newNums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            newNums[i] = transformer(nums[i]);
        }
        return newNums;
    }
    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> newList = new List<int>();
        foreach(int x in nums)
        {
            if (predicate(x)) { newList.Add(x); }
        }
        return newList;
    }
    public int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int results = initialValue;
        for (int i = 0; i < nums.Length / 2; i++)
        {
            results += reducer(nums[i], nums[nums.Length -i - 1]);
        }
        return results;
    }
}