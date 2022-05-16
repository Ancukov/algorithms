using System;
using System.Linq;

namespace binary
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var arrayLengths = Console.ReadLine().Split(' ');
        //    var arrN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    var arrayLengths2 = Console.ReadLine().Split(' ');
        //    var arrM = Console.ReadLine().Split(' ').Select(int.Parse);
        //    var n = int.Parse(arrayLengths[0]);
        //    var m = int.Parse(arrayLengths2[0]);
        //    var res = 0;
        //    var response = "";

        //    foreach (var num in arrM)
        //    {
        //        int[] match = Array.FindAll(arrN, x => x == num);
        //        response += $"{match.Length} ";
        //    }

        //    foreach (var num in arrM)
        //    {
        //        var left = -1;
        //        var right = n - 1;
        //        while (left + 1 < right)
        //        {
        //            var mid = left + (right - left) / 2;
        //            if (arrN[mid] < num)
        //                left = mid;
        //            else
        //                right = mid;
        //        }
        //        if (arrN[right] == num)
        //        {
        //            res = 1;
        //            while (right != arrN.Length - 1 && arrN[right + 1] == num)
        //            {
        //                right += 1;
        //                res += 1;
        //                if (!(right != arrN.Length - 1))
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        response += $"{res} ";
        //        res = 0;
        //        //Console.WriteLine(arrN[right] == num ? right + 1 : 0);
        //    }
        //    Console.WriteLine(response);
        //}
        //static void Main(string[] args)
        //{
        //    string num = Console.ReadLine();
        //    int[] array1 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
        //    string num2 = Console.ReadLine();
        //    int[] array2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
        //    var response = "";
        //    for (int i = 0; i < array2.Length; i++)
        //    {
        //        response += (Binary(array1, array2[i]) + " ");
        //    }
        //    Console.WriteLine(response);
        //}
        //public static int Binary(int[] array, int x)
        //{
        //    var res = 0;
        //    int left = 0;
        //    int right = array.Length;
        //    while (left + 1 < right)
        //    {
        //        int mid = left + (right - left) / 2;
        //        if (array[mid] <= x)
        //        {
        //            left = mid;
        //        }
        //        else
        //        {
        //            right = mid;
        //        }
        //    }
        //    if (array[left] == x)
        //    {
        //        res += 1;
        //        while (left != 0 && array[left - 1] == x)
        //        {
        //            res += 1;
        //            left -= 1;
        //        }
        //        return res;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        public static void Main()
        {
            var arrayLengths = Console.ReadLine().Trim().Split(' ');
            var arrN = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var arrK = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            foreach (var num in arrK)
            {
                //var resSmal = 0;
                //var resBig = 0;
                var res = 0;
                var left = 0;
                var right = arrN.Length - 1;
                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    if (arrN[mid] == num)
                    {
                        res = mid;
                        break;
                    }
                    if (num > arrN[mid])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                if (arrN[res] == num)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    if (left < 0)
                        left = 0;
                    var num1 = arrN[left] - num;
                    if (right < 0)
                        right = 0;
                    var num2 = num - arrN[right];
                    if (num1 >= num2)
                    {
                        Console.WriteLine(arrN[right]);
                    }
                    else
                    {
                        Console.WriteLine(arrN[left]);
                    }

                    //if (num < arrN[arrN.Length - 1])
                    //{
                    //    int i = 0;
                    //    while (arrN[i] <= num)
                    //    {
                    //        resSmal = arrN[i];
                    //        resBig = arrN[i + 1];
                    //        i++;
                    //    }
                    //    resSmal = num - resSmal;
                    //    resBig = resBig - num;
                    //    if (i == 0)
                    //    {
                    //        Console.WriteLine(arrN[i]);
                    //    }
                    //    else if (resBig < resSmal)
                    //    {
                    //        Console.WriteLine(arrN[i]);
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine(arrN[i - 1]);
                    //    }
                    //}
                    //else
                    //{
                    //    Console.WriteLine(arrN[arrN.Length - 1]);
                    //}
                }
            }
        }
    }
}
