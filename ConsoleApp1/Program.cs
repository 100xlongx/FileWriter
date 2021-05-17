using System;
using FileWriter.App;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Publisher Subscriber Project!");
            var pub = new FileWriters();
            var sub1 = new DisplayService("1", pub);
            pub.RaiseInsertMessageEvent("This is Message", "TheFile");
        }
    }
}