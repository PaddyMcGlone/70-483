using System;
using System.Linq;

namespace AggregateExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));

                parallelResult.ForAll(i => Console.WriteLine(i));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There was {0} exception ", e.InnerExceptions.Count());                
            }
        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");

            return i % 2 == 0;
        }
    }
}
