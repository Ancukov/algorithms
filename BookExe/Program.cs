using System;

namespace BookExe
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionC<object> x = Str;
            ActionC<string> y = x;
            y("helllo");
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);
        }
        static void Str(object s)
            => Console.WriteLine(s);
        static void WriteProgressToConsole(int percentCompete)
            => Console.WriteLine(percentCompete);
        static void WriteProgressToFile(int percentCompete)
            => System.IO.File.WriteAllText("progress.txt", percentCompete.ToString());
    }
    public delegate void ProgressReporter(int percentComplete);
    public class Util
    {
        public static void HardWork(ProgressReporter p)
        {
            for (int i = 0; i < 10; i++)
            {
                p(i * 10);
                System.Threading.Thread.Sleep(100);
            }
        }
    }
    public delegate void ActionC<in T>(T arg);
}
