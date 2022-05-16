using System;
using System.Collections.Generic;
using System.Linq;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[] array1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var firstDict = new Dictionary<int, int>();

            foreach (var val in array2)
            {
                var left = 0;
                var right = array1.Length - 1;
                while (left < right)
                {
                    var mid = left + (right - left) / 2;
                    if (array1[mid] == val)
                    {
                        Console.WriteLine(val);
                        break;
                    }
                    if (array1[mid] < val)
                    {
                        left = mid;
                    }
                    else
                    {
                        right = mid;
                    }
                }
            }

                //string str = "";
                //int num1 = int.Parse(Console.ReadLine());
                //int[] array1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                //int num2 = int.Parse(Console.ReadLine());
                //int[] array2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                //var firstDict = new Dictionary<int, int>();

                //foreach(var val in array1)
                //{
                //    if(firstDict.TryGetValue(val, out var _))
                //    {
                //        firstDict[val] += 1;
                //    }
                //    else
                //    {
                //        firstDict[val] = 1;
                //    }
                //}

                //var result = new List<int>();
                //string res = "";


                //foreach(var val in array2)
                //{
                //    if (firstDict.TryGetValue(val, out var count))
                //    {
                //        result.Add(count);
                //        res += count;
                //    }
                //    else
                //    {
                //        result.Add(0);
                //        res += "0";
                //    }
                //}

                //Console.WriteLine(string.Join(" ", result));

                //for (int i = 0; i < array2.Length; i++)
                //{
                //    str += Binary(array1, array2[i]) + " ";
                //}
                //Console.WriteLine(str);
            }
        public static int Binary(int[] array, int x)
        {
            int left = 0;
            int right = array.Length;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] <= x)
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            if (left != 0 && array[left - 1] == x)
            {
                int left2 = -1;
                int right2 = array.Length - 1;
                while (left2 + 1 < right2)
                {
                    int mid2 = left2 + (right2 - left2) / 2;
                    if (array[mid2] < x)
                    {
                        left2 = mid2;
                    }
                    else
                    {
                        right2 = mid2;
                    }
                }
                return left - right2 + 1;
            }
            if (array[left] == x)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
