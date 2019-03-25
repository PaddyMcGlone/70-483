using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAsyncAwait
{
    class Program
    {
        public static void Main(string[] args)
        {
            var result = DownloadContent().Result;
            Console.WriteLine(result);
        }

        public static async Task<string> DownloadContent()
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                var result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
