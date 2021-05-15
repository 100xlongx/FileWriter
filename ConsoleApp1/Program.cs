using System;
using FileWriter.App;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Publisher Subscriber Project!");
            var pub = new Publisher();
            var sub0 = new FileWriters("Sub1", pub);
            var sub1 = new DisplayService("1", pub);
            var sub2 = new DisplayService("2", pub);
            pub.RaiseInsertMessageEvent("This is Message");
        }
    }
}