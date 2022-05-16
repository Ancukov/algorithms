using System;
using System.Linq;

namespace jumpSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string? v = null;
            PrintUpper(v);

            string number = Console.ReadLine();
            int[] arr1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            foreach (int num in arr2)
            {
                Console.WriteLine(Jump(arr1, num));
            }
            int? x = 44;
            int y = x ?? 100;
        }
        static void PrintUpper(string? text)
        {
            Console.WriteLine(text?.ToUpper());
        }
        static int Jump(int[] array, int num)
        {
            int b = (int)Math.Sqrt(array.Length);
            int start = 0;
            int end = b - 1;
            while (array[end] < num)
            {
                if (end == array.Length - 1)
                {
                    break;
                }
                start = Math.Min(array.Length - 1, start + b);
                end = Math.Min(array.Length - 1, end + b);
            }
            if (num > array[end])
            {
                return 0;
            }
            else
            {
                while (end <= array.Length)
                {
                    if (num != array[end])
                    {
                        //return i + 1;
                    }
                    //for (int i = end; i <= end; i++)
                    //{
                    //    if (num == array[i])
                    //    {
                    //        return i + 1;
                    //    }
                    //}
                }
                return 0;

            }
        }
    }
}
        //static int Jump(int[] array, int num)
        //{
        //    int b = (int)Math.Sqrt(array.Length);
        //    int start = array.Length - 1;
        //    int end = array.Length - b;
        //    while(array[end] > num)
        //    {
        //        if(end == 0)
        //        {
        //            break;
        //        }
        //        start = Math.Min(array.Length - 1, start - b);
        //        end = Math.Min(array.Length - 1, end - b);
        //        if(end < 0 || start <= 0)
        //        {
        //            end = 0;
        //            start = b;
        //        }
        //    }
        //    if(num > array[end])
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        for (int i = start; i >= end; i--)
        //        {
        //            if (num == array[i])
        //            {
        //                return i + 1;
        //            }
        //        }
        //    }
        //    return 0;
        //}
