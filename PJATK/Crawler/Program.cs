using System;
using System.Net.Http;

namespace Crawler //jeśli klasy są w tej samej przestrzeni to siebie widzą
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient httpClient = new HttpClient();

            Console.WriteLine("Hello World!");
        }
    }
}
