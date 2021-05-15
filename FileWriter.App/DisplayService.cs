using System;
using FileWriter.App;

namespace ConsoleApp1
{
    //Subscriber
    public class DisplayService
    {
        private readonly string _id;

        public DisplayService(string id, Publisher pub)
        {
            _id = id;

            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        private void HandleCustomEvent(object sender, FileWriteComplete e)
        {
            Console.WriteLine("File Write Completed");
        }
    }
}