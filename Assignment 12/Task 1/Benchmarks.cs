using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_1
{
    public class Benchmarks
    {
        [Benchmark]
        public void BenchmarkArray()
        { 
                int[] array = new int[1000000];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = i;
                }
        }
        [Benchmark]
        public void BenchmarkArrayList()
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(i);
            }
        }
        [Benchmark]
        public void BenchmarkList()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i);
            }
        }
        [Benchmark]
        public void BenchmarkDictionary()
        { 
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < 1000000; i++)
            {
                dictionary.Add(i, i);
            }
        }
        [Benchmark]
        public void BenchmarkSortedList()
        {
            SortedList sortedList = new SortedList();
            for (int i = 0; i < 1000000; i++)
            {
                sortedList.Add(i,i);
            }
        }
        [Benchmark]
        public void BenchmarkHashSet()
        { 
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < 1000000; i++)
            {
                hashSet.Add(i);
            }
        }
        [Benchmark]
        public void BenchmarkStack()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 1000000; i++)
            {
                stack.Push(i);
            }
        }
        [Benchmark]
        public void BenchmarkQueue()
        {  
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < 1000000; i++)
            {
                queue.Enqueue(i);
            }
        }
    }
}
