using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePlinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100000);

            var paralellResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();

            foreach (var item in paralellResult)
                Console.WriteLine(item);
        }
    }
}
