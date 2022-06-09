using System;
using System.Collections;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(4);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    class ArrayList : IClass, IAddRange, IRemove, IRemoveAt, IEnumerable
    {

        public int Capacity { get; set; }
        public int Count { get; set; }

        public object[] arr;

        public ArrayList(int capacity)
        {
            arr = new object[capacity];
        }
        public void Add(object value)
        {
        }
        public void Remove(object obj)
        {
            foreach (var item in arr)
            {
                if (obj == item)
                {
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                }
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        public void RemoveAt(int index)
        {
            for (int i = index; index < arr.Length - 1; index++)
            {
                arr[index] = arr[index + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }
        public void AddRange(ICollection ranges)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < ranges.Count; j++)
                {
                    Array.Resize(ref arr, j);
                    ranges.CopyTo(arr, i);
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}
