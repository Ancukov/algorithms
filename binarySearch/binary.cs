using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    class binary
    {
        static void Mains(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int[] array1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var firstDict = new Dictionary<int, int>();

            foreach (var val in array2)
            {
                var left = 0;
                var right = array1.Length - 1;
                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    if (array1[mid] == val)
                    {
                        Console.WriteLine(val);
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


                //if (firstDict.TryGetValue(val, out var _))
                //{
                //    firstDict[val] += 1;
                //}
                //else
                //{
                //    firstDict[val] = 1;
                //}
            }

            var result = new List<int>();
            string res = "";


            foreach (var val in array2)
            {
                if (firstDict.TryGetValue(val, out var count))
                {
                    result.Add(count);
                    res += count;
                }
                else
                {
                    result.Add(0);
                    res += "0";
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
