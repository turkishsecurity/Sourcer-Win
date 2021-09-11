using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SourcerWIN_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; // konsol rengi kirmizi
            Console.WriteLine("---- S0URCER / Windows Version ----- ");
            Console.WriteLine("Coded By Xale - xalesecurity.wordpress.com");
            Console.WriteLine("Target Site: (Sample: https://www.google.com/)");
            string site = Console.ReadLine();
            string htmlCode = string.Empty;
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(site);

            }
            Console.WriteLine(htmlCode);
          


        }
    }
}
