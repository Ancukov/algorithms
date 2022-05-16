using System;
using System.IO;
//using System.Windows.Forms;

namespace Delegate_work
{
    internal delegate void Feedback(int value);
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            StaticDelegateDemo();
            InstanceDelegateDemo();
            ChainDelegateDemo1(new Program());
            ChainDelegateDemo2(new Program());
        }
        private static void StaticDelegateDemo()
        {
            Console.WriteLine("--- SDD ---");
            Counter(1, 3, null);
            Counter(1, 3, new Feedback(FeedbackToConsole));
            Counter(1, 3, new Feedback(FeedbackToMsgBox));

            Console.WriteLine();
        }
        private static void InstanceDelegateDemo()
        {
            Console.WriteLine("--- IDD ---");
            Program p = new Program();
            Counter(1, 3, new Feedback(p.FeedbackToFile));
        }
        private static void ChainDelegateDemo1(Program p)
        {
            Console.WriteLine("--- CDD1 ---");
            Feedback fb1 = new Feedback(FeedbackToConsole);
            Feedback fb2 = new Feedback(FeedbackToMsgBox);
            Feedback fb3 = new Feedback(p.FeedbackToFile);

            Feedback fbChair = null;
            fbChair = (Feedback)Delegate.Combine(fbChair, fb1);
            fbChair = (Feedback)Delegate.Combine(fbChair, fb2);
            fbChair = (Feedback)Delegate.Combine(fbChair, fb3);
            Counter(1, 2, fbChair);

            Console.WriteLine();
            fbChair = (Feedback)
                Delegate.Remove(fbChair, new Feedback(FeedbackToMsgBox));
            Counter(1, 2, fbChair);
        }
        private static void ChainDelegateDemo2(Program p)
        {
            Console.WriteLine("--- CDD2 ---");
            Feedback fb1 = new Feedback(FeedbackToConsole);
            Feedback fb2 = new Feedback(FeedbackToMsgBox);
            Feedback fb3 = new Feedback(p.FeedbackToFile);

            Feedback fbChain = null;
            fbChain += fb1;
            fbChain += fb2;
            fbChain += fb3;
            Counter(1, 2, fbChain);

            Console.WriteLine();
            fbChain -= new Feedback(FeedbackToMsgBox);
            Counter(1, 2, fbChain);
        }
        private static void Counter(int from, int to, Feedback fb)
        {
            for(int val = from;  val <= to; val++)
            {
                if (fb != null)
                    fb(val);
            }
        }
        private static void FeedbackToConsole(int value)
        {
            Console.WriteLine("Item=" + value);
        }
        private static void FeedbackToMsgBox(int value)
        {
            Console.WriteLine("Item=" + value);
        }
        private void FeedbackToFile(int value )
        {
            using (StreamWriter sw = new StreamWriter("Status", true))
            {
                sw.WriteLine("Item=" + value);
            }
        }
    }
}
