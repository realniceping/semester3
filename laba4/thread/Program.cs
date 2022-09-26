using System;
using System.Threading;
using System.IO;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1>>");
            string x1s = Console.ReadLine();
            Console.Write("s1>>");
            string s1s = Console.ReadLine();
            double x1 = Convert.ToDouble(x1s);
            double s1 = Convert.ToDouble(s1s);

            Console.Write("x2>>"); //start
            string x2s = Console.ReadLine();
            Console.Write("s2>>"); // step
            string s2s = Console.ReadLine();
            Console.Write("d2(ms)>>"); // latency
            string d2s = Console.ReadLine();
            Console.Write("t2(s)>>"); // time
            string t2s = Console.ReadLine();

            double x2 = Convert.ToDouble(x2s);
            double s2 = Convert.ToDouble(s2s);
            int d2 = Convert.ToInt32(d2s);
            int t2 = Convert.ToInt32(t2s);

            Thread ParentThread = new Thread(delegate () { FirstThreader.main(x1, s1); });
            ParentThread.Start();
            SecondThread secondThreadObject = new SecondThread();
            Thread SecondThread = new Thread(delegate () { secondThreadObject.main(x2, s2, d2, t2); });
            SecondThread.Start();
        }
    }

    public class FirstThreader
    {
        public static async void main(double x1, double s1)
        {



            using StreamWriter file = new("thread1.dat");
            for (int i = 0; i < 100; i++)
            {
                await file.WriteLineAsync(DateTime.Now + " value X:" + x1 + " value Y: " + Math.Log(x1));
                x1 = x1 + s1;
                Thread.Sleep(500);
            }

        }
    }

    public class SecondThread
    {
        public async void main(double x2, double s2, int d2, int t2)
        {


            using StreamWriter file = new("thread2.dat");
            DateTime current = DateTime.Now;
            long currentSecond = current.Second;

            long finshSecod = currentSecond + t2;

            while (currentSecond < finshSecod)
            {
                await file.WriteLineAsync(DateTime.Now + " value X:" + x2 + " value Y: " + 1 / x2);
                x2 = x2 + s2;
                current = DateTime.Now;
                currentSecond = current.Second;
                Thread.Sleep(d2);
            }

        }

    }

}