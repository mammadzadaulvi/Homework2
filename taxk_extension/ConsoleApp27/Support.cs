using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    static class Support
    {
        public static int[] Add(this int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
            return arr;
        }
    }
}
