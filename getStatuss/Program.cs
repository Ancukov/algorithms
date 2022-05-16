using System;
using System.Text;
using System.Reflection;

namespace getStatuss
{
    internal sealed class Light
    {
        public string SwitchPosition()
        {
            return "The light is off";
        }
    }

    internal sealed class Fan
    {
        public string Speed()
        {
            throw new InvalidOperationException("The fan broke due to overheating");
        }
    }

    internal sealed class Speaker
    {
        public string Volume()
        {
            return "The volume is loud";
        }
    }

    public sealed class Program
    {
        private delegate string GetStatus();
        public static void Main(string[] args)
        {
            GetStatus getStatus = null;
            getStatus += new GetStatus(new Light().SwitchPosition);
            getStatus += new GetStatus(new Fan().Speed);
            getStatus += new GetStatus(new Speaker().Volume);

            Console.WriteLine(GetComponentStatusReport(getStatus));
        }
        private static string GetComponentStatusReport(GetStatus status)
        {
            if (status == null) return null;

            StringBuilder report = new StringBuilder();

            Delegate[] arrayOfDelegetes = status.GetInvocationList();
            
            foreach(GetStatus getStatus in arrayOfDelegetes)
            {
                try
                {
                    report.AppendFormat("{0}{1}{1}", getStatus(), Environment.NewLine);
                }
                catch(InvalidOperationException e)
                {
                    object component = getStatus.Target;
                    report.AppendFormat(
                        "Failed to get status from {1}{2}{0} Error: {3}{0}{0}",
                        Environment.NewLine,
                        ((component == null) ? " " : component.GetType() + "."),
                        getStatus.Method.Name,
                        e.Message);
                }
            }

            return report.ToString();
        }
    }
}
