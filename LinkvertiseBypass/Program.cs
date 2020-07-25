using System;
using System.Diagnostics;
using Leaf.xNet;

namespace LinkvertiseBypass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put your linkvertise link here: ");
            var link = Console.ReadLine();

            using (HttpRequest bypass = new HttpRequest())
            {
                var resp = bypass.Post($"https://online-coding.eu/api/LinkvertiseBypass.php?url={link}");
                Process.Start(resp.ToString());
            }
        }
    }
}