using System;
using System.Threading;

namespace SimpleMultiThread
{
    public static class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc : {0}", i);
                Thread.Sleep(0);
            }
        }


        // Console class uses synchronisation so we can write using multi-threads.
        public static void Main(string[] args)
        {
            var t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread.. do some work");
                Thread.Sleep(0);
            }

            t.Join();
        }
    }
}
