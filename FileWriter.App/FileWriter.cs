using System;
using System.IO;

namespace FileWriterEvents.App
{
    public class FileWriter
    {
        public FileWriter(string fileName, Publisher pub)
        {
            FileName = fileName;

            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        public string FileName { get; }

        // Define what actions to take when the event is raised.
        private void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            File.WriteAllText(@"./test.txt", $"Wrote PICKLE RICK to {FileName}: {e.Message}");

            Console.WriteLine($"Wrote PICKLE RICK to {FileName}: {e.Message}");
        }
    }
}