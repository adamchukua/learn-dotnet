using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();

        public static void UpToSeconds()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        public static void DownToSeconds()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }

        public static async Task GetYtImageAsync(string link)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(link);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                var doc = new HtmlDocument();
                doc.LoadHtml(responseBody);

                var title = doc.DocumentNode.SelectSingleNode("//head/title").InnerHtml;

                Console.WriteLine(title);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine($"Message :{e.Message} ");
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Thread thread1 = new Thread(UpToSeconds);
            Thread thread2 = new Thread(DownToSeconds);

            //thread1.Start();
            //thread2.Start();

            Program.GetYtImageAsync(Console.ReadLine());

            Console.WriteLine("The End");
            Console.ReadLine();
        }
    }
}
