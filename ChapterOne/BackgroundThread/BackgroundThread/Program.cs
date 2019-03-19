using System;
using System.Threading;

namespace BackgroundThread
{
    public class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main(string[] args)
        {
            var t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = false;
            t.Start();
        }
    }
}
