using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://chmnu.edu.ua/category/zapisi/novini/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                var doc = new HtmlDocument();
                doc.LoadHtml(responseBody);

                List<String> news = new List<String>();
                news.AddRange(doc.DocumentNode.Descendants("h3").Select(nd => nd.InnerText));

                // Not news
                news.RemoveRange(news.Count - 3, 3);

                foreach (var newsItem in news)
                {
                    Console.WriteLine($"{newsItem}\n");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine($"Message :{e.Message} ");
            }

            Console.ReadLine();
        }


    }
}
