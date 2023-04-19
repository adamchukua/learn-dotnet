using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var weatherstack = new WeatherstackHttpClient();

            var response = await weatherstack.GetCurrent("New York");
            if (response.StatusCode == (int)System.Net.HttpStatusCode.OK)
            {
                var weather = response.Current;
                Console.WriteLine(weather);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }

            Console.ReadLine();
        }
    }
}
