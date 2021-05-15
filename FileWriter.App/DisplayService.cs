using System;

namespace FileWriter.App
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

        public string Id()
        {
            return _id;
        }

        private void HandleCustomEvent(object sender, FileWriteComplete e)
        {
            Console.WriteLine($"{_id} File Write Completed");
        }
    }
}