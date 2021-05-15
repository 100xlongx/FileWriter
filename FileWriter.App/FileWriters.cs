using System;
using System.IO;

namespace FileWriter.App
{
    public class FileWriters
    {
        private readonly string _fileName;

        public FileWriters(string fileName, Publisher pub)
        {
            _fileName = fileName;

            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        private void HandleCustomEvent(object sender, FileWriteComplete e)
        {
            File.AppendAllText(@"../../../../text.txt",
                $"Wrote PICKLE RICK to {_fileName}: {e.Message}\n");

            Console.WriteLine($"Wrote PICKLE RICK to {_fileName}: {e.Message}");
        }
    }
}